using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SacoZori : MonoBehaviour
{
    public InputController inputController;
    public Collider jogador;
    private float distancetoJogador;
    public AudioClip collectSound;
    public GameObject collectEffect;
    public Canvas mensagem, roberto;

    void Start()
    {

    }

    void Update()
    {
        distancetoJogador = Vector3.Distance(transform.position, jogador.transform.position);
        string estado = PlayerPrefs.GetString("coletado" + gameObject.name);
        if (estado == "true")
        {
            Destroy(gameObject);
        }
        if (distancetoJogador < 5.0f && inputController.GetPlayerItem() && PlayerPrefs.GetString("robertoitens")== "tem")
        {
            PlayerPrefs.SetInt("temsaco",1);
            Collect();
            PlayerPrefs.SetString("coletado" + gameObject.name, "true");
            Destroy(gameObject);

        }

        if (distancetoJogador < 5.0f && inputController.GetPlayerItem() && PlayerPrefs.GetString("robertoitens") != "tem")
        {
            roberto.enabled = true;
        }
    }

    public void Collect()
    {
        if (collectSound)
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        if (collectEffect)
            Instantiate(collectEffect, transform.position, Quaternion.identity);

    }

    private void OnTriggerEnter(Collider other) //qd entra no trigger
    {
        if (other.tag == "Player")
        {
            mensagem.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            mensagem.enabled = false;
        }
    }
}
