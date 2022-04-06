using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minku_script : MonoBehaviour
{
    public InputController inputController;
    public Collider zorri, robert;
    public RawImage fundo_inventario, imaca, inoz,iamora,igroselha,imal,icen;
    public Collider[] maca, noz, amora, groselha, malagueta, cenoura;
    public Collider[] meuros_collider;
    public Text n_mac, n_n, n_g,n_a, n_mal, n_cen, n_meuros;
    public int q_maca=0, q_noz=0, q_amora=0, q_groselha=0,q_malagueta=0, q_cenoura;
    public float d_maca,d_noz,d_amora,d_groselha, d_malagueta, d_cenoura, d_zorii, d_robert, d_meuros;
    public int numeromeuros = 0;
    public Button compra_macas, compra_noz, compra_amora, compra_groselha, compra_malagueta, compra_cenoura, button_troca;
    public bool tem_saco = false;

    void Start()
    {
        
    }

    void Update()
    {
        // APANHAR OS ITENS

        //meuros
        for (int i = 0; i < meuros_collider.Length; i++)
        {
            if (meuros_collider[i] != null)
            {
                d_meuros = Vector3.Distance(transform.position, meuros_collider[i].transform.position);
                if (d_meuros < 3.0f && inputController.GetPlayerItem())
                {
                    numeromeuros++;
                    n_meuros.text = numeromeuros.ToString();
                    meuros_collider[i] = null;
                }
            }
        }

        // ma��s
        for (int i = 0; i < maca.Length; i++)
        {
            if (maca[i] != null)
            {
                d_maca = Vector3.Distance(transform.position, maca[i].transform.position);
                if (d_maca < 3.0f && inputController.GetPlayerItem())
                {
                    q_maca++;
                    n_mac.text = q_maca.ToString();
                    maca[i] = null;
                }
            }
        }

        // noz
        for (int i = 0; i < noz.Length; i++)
        {
            if (noz[i] != null)
            {
                d_noz = Vector3.Distance(transform.position, noz[i].transform.position);
                if (d_noz < 3.0f && inputController.GetPlayerItem())
                {
                    q_noz++;
                    n_n.text = q_noz.ToString();
                    noz[i] = null;
                }
            }
        }

        // amora
        for (int i = 0; i < amora.Length; i++)
        {
            if (amora[i] != null)
            {
                d_amora = Vector3.Distance(transform.position, amora[i].transform.position);
                if (d_amora < 3.0f && inputController.GetPlayerItem())
                {
                    q_amora++;
                    n_a.text = q_amora.ToString();
                    amora[i] = null;
                }
            }
        }

        // groselha
        for (int i = 0; i < groselha.Length; i++)
        {
            if (groselha[i] != null)
            {
                d_groselha = Vector3.Distance(transform.position, groselha[i].transform.position);
                if (d_groselha < 3.0f && inputController.GetPlayerItem())
                {
                    q_groselha++;
                    n_g.text = q_groselha.ToString();
                    groselha[i] = null;
                }
            }
        }

        // malagueta
        for (int i = 0; i < malagueta.Length; i++)
        {
            if (malagueta[i] != null)
            {
                d_malagueta = Vector3.Distance(transform.position, malagueta[i].transform.position);
                if (d_malagueta < 3.0f && inputController.GetPlayerItem())
                {
                    q_malagueta++;
                    n_mal.text = q_malagueta.ToString();
                    malagueta[i] = null;
                }
            }
        }

        // cenoura
        for (int i = 0; i < cenoura.Length; i++)
        {
            if (cenoura[i] != null)
            {
                d_cenoura = Vector3.Distance(transform.position, cenoura[i].transform.position);
                if (d_cenoura < 3.0f && inputController.GetPlayerItem())
                {
                    q_cenoura++;
                    n_cen.text = q_cenoura.ToString();
                    cenoura[i] = null;
                }
            }
        }

        // se a distancia h� loja do zorii for menor que 3, o bot�o de compra tenha sido premido e
        // haja meuros sufecientes, a compra � feita
        d_zorii = Vector3.Distance(transform.position, zorri.transform.position);
        d_robert = Vector3.Distance(transform.position, robert.transform.position);
        if (d_zorii < 6.0f && tem_saco)
        {
            if (compra_macas.name == "acesso maca concedido" && numeromeuros >= 5)
            {
                numeromeuros -= 5;
                q_maca++;
                n_meuros.text = numeromeuros.ToString();
                n_mac.text = q_maca.ToString();
                compra_macas.name = "a";

            }

            if (compra_noz.name == "acesso noz concedido" && numeromeuros >= 2)
            {
                numeromeuros -= 2;
                q_noz++;
                n_meuros.text = numeromeuros.ToString();
                n_n.text = q_noz.ToString();
                compra_noz.name = "noz";

            }

            if (compra_amora.name == "acesso amora concedido" && numeromeuros >= 3)
            {
                numeromeuros -= 3;
                q_amora++;
                n_meuros.text = numeromeuros.ToString();
                n_a.text = q_amora.ToString();
                compra_amora.name = "amora";

            }

            if (compra_groselha.name == "acesso groselha concedido" && numeromeuros >= 3)
            {
                numeromeuros -= 3;
                q_groselha++;
                n_meuros.text = numeromeuros.ToString();
                n_g.text = q_groselha.ToString();
                compra_groselha.name = "groselha";

            }

            if (compra_malagueta.name == "acesso malagueta concedido" && numeromeuros >= 13)
            {
                numeromeuros -= 13;
                q_malagueta++;
                n_meuros.text = numeromeuros.ToString();
                n_mal.text = q_malagueta.ToString();
                compra_malagueta.name = "malagueta";

            }

            if (compra_cenoura.name == "acesso cenoura concedido" && numeromeuros >= 20)
            {
                numeromeuros -= 20;
                q_cenoura++;
                n_meuros.text = numeromeuros.ToString();
                n_cen.text = q_cenoura.ToString();
                compra_cenoura.name = "cenoura";

            }
        }

        // VER INVENT�RIO, tamb�m, abre na loja
        if (inputController.GetPlayerInventario() || d_zorii < 6.0f && inputController.GetPlayerItem() && tem_saco ||
            d_robert<6.0f && inputController.GetPlayerItem())
        {
            fundo_inventario.enabled = !fundo_inventario.enabled;
            n_mac.enabled = !n_mac.enabled;
            imaca.enabled = !imaca.enabled;
            n_n.enabled = !n_n.enabled;
            inoz.enabled = !inoz.enabled;
            n_g.enabled = !n_g.enabled;
            igroselha.enabled = !igroselha.enabled;
            n_a.enabled = !n_a.enabled;
            iamora.enabled = !iamora.enabled;
            n_mal.enabled = !n_mal.enabled;
            imal.enabled = !imal.enabled;
            n_cen.enabled = !n_cen.enabled;
            icen.enabled = !icen.enabled;
            n_meuros.enabled = !n_meuros.enabled;
            n_meuros.text = numeromeuros.ToString();
        }

        // Troca de informa��o por cenouras
        if (q_cenoura > 0) button_troca.interactable = true;
        else button_troca.interactable = false;

    }
}
