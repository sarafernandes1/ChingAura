using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minku_script : MonoBehaviour
{
    public InputController inputController;
    public Collider zorri;
    public RawImage fundo_inventario, imaca, inoz,iamora,igroselha,imal,icen;
    public Collider[] maca, noz, amora, groselha, malagueta, cenoura;
    // mac -> ma��
    // n -> noz
    // g-> groselha
    // a -> amora
    // mal -> malagueta
    // cen -> cenoura
    public Text n_mac, n_n, n_g,n_a, n_mal, n_cen, n_meuros;
    public int q_maca=0, q_noz=0, q_amora=0, q_groselha=0,q_malagueta=0, q_cenoura;
    public float d_maca,d_noz,d_amora,d_groselha, d_malagueta, d_cenoura, d_zorii;
    public int q_meuros = 20;
    public Button compra_macas, compra_noz, compra_amora, compra_groselha, compra_malagueta, compra_cenoura;

    void Start()
    {
        
    }

    void Update()
    {
        // APANHAR OS ITENS

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
        if (d_zorii < 3.0f && compra_macas.name == "acesso maca concedido" && q_meuros >= 5)
        {
                q_meuros -= 5;
                q_maca++;
                n_meuros.text = q_meuros.ToString();
                n_mac.text = q_maca.ToString();
                compra_macas.name = "a";
            
        }

        if (d_zorii < 3.0f && compra_noz.name == "acesso noz concedido" && q_meuros >= 2)
        {
            q_meuros -= 2;
            q_noz++;
            n_meuros.text = q_meuros.ToString();
            n_n.text = q_noz.ToString();
            compra_noz.name = "noz";

        }

        if (d_zorii < 3.0f && compra_amora.name == "acesso amora concedido" && q_meuros >= 3)
        {
            q_meuros -= 3;
            q_amora++;
            n_meuros.text = q_meuros.ToString();
            n_a.text = q_amora.ToString();
            compra_amora.name = "amora";

        }

        if (d_zorii < 3.0f && compra_groselha.name == "acesso groselha concedido" && q_meuros >= 3)
        {
            q_meuros -= 3;
            q_groselha++;
            n_meuros.text = q_meuros.ToString();
            n_g.text = q_groselha.ToString();
            compra_groselha.name = "groselha";

        }

        if (d_zorii < 3.0f && compra_malagueta.name == "acesso malagueta concedido" && q_meuros >= 13)
        {
            q_meuros -= 13;
            q_malagueta++;
            n_meuros.text = q_meuros.ToString();
            n_mal.text = q_malagueta.ToString();
            compra_malagueta.name = "malagueta";

        }

        if (d_zorii < 3.0f && compra_cenoura.name == "acesso cenoura concedido" && q_meuros >= 20)
        {
            q_meuros -= 20;
            q_cenoura++;
            n_meuros.text = q_meuros.ToString();
            n_cen.text = q_cenoura.ToString();
            compra_cenoura.name = "cenoura";

        }

        // VER INVENT�RIO, tamb�m, abre na loja
        if (inputController.GetPlayerInventario() || d_zorii < 3.0f && inputController.GetPlayerItem())
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
            n_meuros.text = q_meuros.ToString();
        }

    }
}
