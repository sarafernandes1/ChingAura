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
    public Text m, n, a, g, c, mal, buttontext, bt2, bt3, bt4, bt5, bt6, tmeuros;
    public RawImage caixatexto,npcimagem;
    public Text texto, nome, textbutton, tb1, loja_aberta_fechada;
    public CharacterController characterController;
    public Button c_maca, c_noz, c_amora, c_groselha, c_malagueta, c_cenoura, continuar, continuar1;
    public int numero_meuros;
    private bool to_inteiro, tem_saco=false, primeiro_dialogo=false, sair_loja=false, venda=false;
    public Collider saco_fruta;
    public Canvas loja_indisponivel, loja_disponivel, dialogo_comprou, dialogo_naocomprou;
    public MeshRenderer caixa1, caixa2, saco1;

    void Start()
    {
    }

    void Update()
    {
        int saco = PlayerPrefs.GetInt("temsaco");
        if (saco==1)
        {
            tem_saco = true;
            caixa1.enabled = true;
            caixa2.enabled = true;
            saco1.enabled = true;

        }

        PlayerPrefs.SetInt("inventarioloja", 1);
        to_inteiro = int.TryParse(tmeuros.text, out numero_meuros);
        distancetoMinku = Vector3.Distance(transform.position, minku.transform.position); 
        if (distancetoMinku < 12.0f && inputController.GetPlayerItem() && tem_saco
            && !primeiro_dialogo && !fundo.enabled)
        {
            venda = false;
            texto.text = "Sauda��es meu caro, o que vai comprar hoje?";
            caixatexto.enabled = true;
            npcimagem.enabled = true;
            continuar.image.enabled = true;
            textbutton.enabled = true;
            texto.enabled = true;
            nome.enabled = true;
            loja_disponivel.enabled = false;
            loja_indisponivel.enabled = false;
        }

        if (distancetoMinku<12.0f && tem_saco && primeiro_dialogo)
        {
            caixatexto.enabled = false;
            npcimagem.enabled = false;
            continuar.image.enabled = false;
            textbutton.enabled = false;
            texto.enabled = false;
            nome.enabled = false;
            continuar.name = "a";
            fundo.enabled = true;
            m.enabled = true;
            n.enabled = true;
            a.enabled = true;
            g.enabled = true;
            c.enabled = true;
            mal.enabled = true;
            c_maca.image.enabled = true;
            buttontext.enabled = true;
            c_noz.image.enabled = true;
            bt2.enabled = true;
            c_amora.image.enabled = true;
            bt3.enabled = true;
            c_groselha.image.enabled = true;
            bt4.enabled = true;
            c_malagueta.image.enabled = true;
            bt5.enabled = true;
            c_cenoura.image.enabled = true;
            bt6.enabled = true;
        }

        if (distancetoMinku < 12.0f && tem_saco && primeiro_dialogo && inputController.GetPlayerItem())
        {
            fundo.enabled = false;
            m.enabled = false;
            n.enabled = false;
            a.enabled = false;
            g.enabled = false;
            c.enabled = false;
            mal.enabled = false;
            c_maca.image.enabled = false;
            buttontext.enabled = false;
            c_noz.image.enabled = false;
            bt2.enabled = false;
            c_amora.image.enabled = false;
            bt3.enabled = false;
            c_groselha.image.enabled = false;
            bt4.enabled = false;
            c_malagueta.image.enabled = false;
            bt5.enabled = false;
            c_cenoura.image.enabled = false;
            bt6.enabled = false;
            primeiro_dialogo = false;
            if (venda)
            {
                dialogo_comprou.enabled = true;
            }
            else
            {
                dialogo_naocomprou.enabled = true;
            }
        }

        if (sair_loja)
        {
            dialogo_comprou.enabled = false;
            dialogo_naocomprou.enabled = false;
            sair_loja = false;
        }

        // Ativar ou desativar os butoes de compra, dependendo do n�mero de meuros
        if (to_inteiro) numero_meuros = int.Parse(tmeuros.text);
        if (numero_meuros >= 5) c_maca.interactable = true;
        else c_maca.interactable = false;
        if (numero_meuros >= 2) c_noz.interactable = true;
        else c_noz.interactable = false;
        if (numero_meuros >= 3) c_amora.interactable = true;
        else c_amora.interactable = false;
        if (numero_meuros >= 3) c_groselha.interactable = true;
        else c_groselha.interactable = false;
        if (numero_meuros >= 13) c_malagueta.interactable = true;
        else c_malagueta.interactable = false;
        if (numero_meuros >= 20) c_cenoura.interactable = true;
        else c_cenoura.interactable = false;
    }

    public void Continuar()
    {
        continuar.name = "continuar";
        primeiro_dialogo = true;
    }

    public void ContinuarUltimoDialogo()
    {
        sair_loja = true;
    }

    public void SairLoja()
    {
        continuar1.name = "sair";
    }

    // Quando clica no bot�o, compra itens
    public void ComprarMaca() 
    {
        Debug.Log("compra");
        venda = true;
        c_maca.name = "acesso maca concedido";
    }
    public void CompraNoz()
    {
        Debug.Log("compra");
        venda = true;

        c_noz.name = "acesso noz concedido";
    }
    public void ComprarAmora()
    {
        Debug.Log("compra");
        venda = true;

        c_amora.name = "acesso amora concedido";
    }
    public void ComprarGroselha()
    {
        Debug.Log("compra");
        venda = true;

        c_groselha.name = "acesso groselha concedido";
    }
    public void ComprarMalagueta()
    {
        Debug.Log("compra");
        venda = true;

        c_malagueta.name = "acesso malagueta concedido";
    }
    public void ComprarCenoura()
    {
        Debug.Log("compra");
        venda = true;

        c_cenoura.name = "acesso cenoura concedido";
    }

    private void OnTriggerEnter(Collider other) //qd entra no trigger
    {
        if (other.tag == "Player")
        {
            if (tem_saco)
            {
                loja_disponivel.enabled = true;
            }
            else
            {
                loja_indisponivel.enabled = true;
            }
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            loja_disponivel.enabled = false;
            loja_indisponivel.enabled = false;
        }
    }
}
