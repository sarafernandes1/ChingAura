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
        // Se o item � apanhado � destruido 
        // assim, n�o vai ser novamente apanhado
        distancetoJogador = Vector3.Distance(transform.position, jogador.transform.position);
        if (distancetoJogador < 3.0f && inputController.GetPlayerItem())
        {
            Collect();
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
