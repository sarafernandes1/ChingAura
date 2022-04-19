using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itensdestroy : MonoBehaviour
{
    public InputController inputController;
    public Collider jogador;
    private float distancetoJogador;
    public AudioClip collectSound;
    public GameObject collectEffect;

    void Start()
    {

    }

    void Update()
    {
        // Se o item é apanhado é destruido 
        // assim, não vai ser novamente apanhado
        distancetoJogador = Vector3.Distance(transform.position, jogador.transform.position);
        string estado = PlayerPrefs.GetString("coletado" + gameObject.name);
        if (estado == "true")
        {
            Destroy(gameObject);
        }
        if (distancetoJogador < 5.0f && inputController.GetPlayerItem())
        {
            Collect();
            PlayerPrefs.SetString("coletado" + gameObject.name, "true");
            Destroy(gameObject);
            
        }
    }

    public void Collect()
    {
        if (collectSound)
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        if (collectEffect)
            Instantiate(collectEffect, transform.position, Quaternion.identity);

    }
}
