using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minku_script : MonoBehaviour
{
    public RawImage fundo_inventario;
    public Collider[] barata;
    public Text n_item,n_mac, n_n, n_g,n_a, n_mal;
    public int q_maca=0, q_noz=0, q_amora=0, q_groselha=0,q_malagueta=0;
    public float d, d_maca,d_noz,d_amora,d_groselha, d_malagueta;

    void Start()
    {
        
    }

    void Update()
    {
        // apnhar itens
        for (int i = 0; i < barata.Length; i++)
        {
            d = Vector3.Distance(transform.position, barata[i].transform.position);
            if (d < 3.0f && Input.GetKeyDown(KeyCode.X))
            {
                q_maca++;
                n_item.text = q_maca.ToString();
                barata[i].transform.position = Vector3.zero;
            }

        }

        // ver inventario
        if (Input.GetKeyDown(KeyCode.I))
        {
            fundo_inventario.enabled = !fundo_inventario.enabled;
            n_item.enabled = !n_item.enabled;
        }

    }
}
