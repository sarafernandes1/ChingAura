using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itensdestroy : MonoBehaviour
{
    public InputController inputController;
    public Collider jogador;
    private float distancetoJogador;

    void Start()
    {
        
    }

    void Update()
    {
        // Se o item � apanhado � destruido 
        // assim, n�o vai ser novamente apanhado
        distancetoJogador = Vector3.Distance(transform.position, jogador.transform.position);
        if(distancetoJogador < 3.0f && inputController.GetPlayerItem())
        {
            Destroy(gameObject);
        }
    }
}
