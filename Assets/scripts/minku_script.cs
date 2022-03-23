using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minku_script : MonoBehaviour
{
    public InputController inputController;
    public RawImage fundo_inventario;
    public Collider[] maca, noz, amora, groselha, malagueta, cenoura;
    // mac -> maçã
    // n -> noz
    // g-> groselha
    // a -> amora
    // mal -> malagueta
    // cen -> cenoura
    public Text n_mac, n_n, n_g,n_a, n_mal, n_cen;
    public int q_maca=0, q_noz=0, q_amora=0, q_groselha=0,q_malagueta=0, q_cenoura;
    public float d_maca,d_noz,d_amora,d_groselha, d_malagueta, d_cenoura;

    void Start()
    {
        
    }

    void Update()
    {
        // APANHAR OS ITENS

        // maçãs
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

        // VER INVENTÁRIO
        if (inputController.GetPlayerInventario())
        {
            fundo_inventario.enabled = !fundo_inventario.enabled;
            n_mac.enabled = !n_mac.enabled;
            n_n.enabled = !n_n.enabled;
            n_g.enabled = !n_g.enabled;
            n_a.enabled = !n_a.enabled;
            n_mal.enabled = !n_mal.enabled;
            n_cen.enabled = !n_cen.enabled;
        }

    }
}
