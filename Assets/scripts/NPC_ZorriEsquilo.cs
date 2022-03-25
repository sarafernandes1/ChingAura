using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_ZorriEsquilo : MonoBehaviour
{
    public Collider minku;
    public float distancetoMinku;
    public InputController inputController;
    public RawImage fundo;
    public Text m, n, a, g, c, mal, buttontext, bt2, bt3, bt4, bt5, bt6;
    public CharacterController characterController;
    public Button c_maca, c_noz, c_amora, c_groselha, c_malagueta, c_cenoura;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
;        distancetoMinku = Vector3.Distance(transform.position, minku.transform.position);
        if(distancetoMinku<3.0f && inputController.GetPlayerItem())
        {
            characterController.enabled = false;
            fundo.enabled = !fundo.enabled;
            m.enabled = !m.enabled;
            n.enabled = !n.enabled;
            a.enabled = !a.enabled;
            g.enabled = !g.enabled;
            c.enabled = !c.enabled;
            mal.enabled = !mal.enabled;
            c_maca.image.enabled = !c_maca.image.enabled;
            buttontext.enabled = !buttontext.enabled;
            c_noz.image.enabled = !c_noz.image.enabled;
            bt2.enabled = !bt2.enabled;
            c_amora.image.enabled = !c_amora.image.enabled;
            bt3.enabled = !bt3.enabled;
            c_groselha.image.enabled = !c_groselha.image.enabled;
            bt4.enabled = !bt4.enabled;
            c_malagueta.image.enabled = !c_malagueta.image.enabled;
            bt5.enabled = !bt5.enabled;
            c_cenoura.image.enabled = !c_cenoura.image.enabled;
            bt6.enabled = !bt6.enabled;
        }

        // Quando está na loja, não se consegue mexer
        // quando sai o jogador já pode se movimentar
        if (!fundo.enabled)
        {
            characterController.enabled = true;
        }

    }

    // Quando clica no botão, compra itens
    public void ComprarMaca() 
    {
        Debug.Log("compra");
        c_maca.name = "acesso maca concedido";
    }
    public void CompraNoz()
    {
        Debug.Log("compra");
        c_noz.name = "acesso noz concedido";
    }
    public void ComprarAmora()
    {
        Debug.Log("compra");
        c_amora.name = "acesso amora concedido";
    }
    public void ComprarGroselha()
    {
        Debug.Log("compra");
        c_groselha.name = "acesso groselha concedido";
    }
    public void ComprarMalagueta()
    {
        Debug.Log("compra");
        c_malagueta.name = "acesso malagueta concedido";
    }
    public void ComprarCenoura()
    {
        Debug.Log("compra");
        c_cenoura.name = "acesso cenoura concedido";
    }

}
