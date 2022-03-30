using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Robert : MonoBehaviour
{
    public InputController inputController;
    public Collider minku;
    public Button troca;
    public Text texto_tela, texto_button, texto_cenouras;
    public int numero_cenouras = 0;
    private float distanceToMinku;
    public CharacterController characterController;
    private bool to_inteiro;

    void Start()
    {
        
    }

    void Update()
    {
        distanceToMinku = Vector3.Distance(transform.position, minku.transform.position);
        to_inteiro = int.TryParse(texto_cenouras.text, out numero_cenouras);
        if(distanceToMinku<6.0f && inputController.GetPlayerItem())
        {
            troca.image.enabled = !troca.image.enabled;
            texto_tela.enabled = !texto_tela.enabled;
            texto_button.enabled = !texto_button.enabled;
            if(to_inteiro) numero_cenouras = int.Parse(texto_cenouras.text);
            characterController.enabled = false;
        }

        if (!texto_tela.enabled)
        {
            characterController.enabled = true;
        }
    }

    public void GetPlayerTroca()
    {
        Debug.Log("troca cenouras por informação");

    }
}
