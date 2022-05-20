using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minku_script : MonoBehaviour
{
    public InputController inputController;
    public Collider zorri, /*robert,*/ saco_fruta;
    public RawImage fundo_inventario, imaca, inoz,iamora,igroselha,imal,icen, imeuros;
    public Collider[] maca, noz, amora, groselha, malagueta, cenoura;
    public Collider[] meuros_collider;
    public Text n_mac, n_n, n_g,n_a, n_mal, n_cen, n_meuros;
    public int q_maca=0, q_noz=0, q_amora=0, q_groselha=0,q_malagueta=0, q_cenoura;
    public float d_maca,d_noz,d_amora,d_groselha, d_malagueta, d_cenoura, d_zorii, d_robert, d_meuros;
    public int numeromeuros = 0, save=0;
    public Button compra_macas, compra_noz, compra_amora, compra_groselha, compra_malagueta, compra_cenoura/*, button_troca*/;
    public bool tem_saco = false, venda=false;
        
    void Start()
    {

        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicaFundo>().PlayMusic();
    }

    void Update()
    {

        numeromeuros = PlayerPrefs.GetInt("numeromeuros");
        q_maca = PlayerPrefs.GetInt("numeromaca");
        q_noz = PlayerPrefs.GetInt("numeronoz");
        q_amora = PlayerPrefs.GetInt("numeroamora");
        q_groselha = PlayerPrefs.GetInt("numerogroselha");
        q_malagueta = PlayerPrefs.GetInt("numeromalagueta");
        q_cenoura = PlayerPrefs.GetInt("numerocenoura");
        
        // APANHAR OS ITENS
        ApanharItens(meuros_collider, d_meuros, numeromeuros, n_meuros, "numeromeuros","Meuro");
        ApanharItens(maca, d_maca, q_maca, n_mac, "numeromaca","Ma��");
        ApanharItens(noz, d_noz, q_noz, n_n, "numeronoz","Noz");
        ApanharItens(amora, d_amora, q_amora, n_a, "numeroamora","Amora");
        ApanharItens(groselha, d_groselha, q_groselha, n_g, "numerogroselha","Groselha");
        ApanharItens(malagueta, d_malagueta,q_malagueta, n_mal, "numeromalagueta","Malagueta");
        ApanharItens(cenoura, d_cenoura, q_cenoura, n_cen, "numerocenoura","Cenoura");

        // se a distancia h� loja do zorii for menor que 3, o bot�o de compra tenha sido premido e
        // haja meuros sufecientes, a compra � feita
        if (zorri != null)
        {
            d_zorii = Vector3.Distance(transform.position, zorri.transform.position);
            //d_robert = Vector3.Distance(transform.position, robert.transform.position);
            if (saco_fruta != null)
            {
                float d_saco = Vector3.Distance(transform.position, saco_fruta.transform.position);
                if (d_saco < 5.0f && inputController.GetPlayerItem())
                {
                    tem_saco = true;
                    PlayerPrefs.SetInt("temsaco", 1);
                }
                int saco = PlayerPrefs.GetInt("temsaco");
                if (saco == 1) tem_saco = true;
                else tem_saco = false;
            }

            if (d_zorii < 12.0f && PlayerPrefs.GetInt("temsaco") == 1)
            {
                if (compra_macas.name == "acesso maca concedido" && numeromeuros >= 5)
                {
                    numeromeuros -= 5;
                    q_maca++;
                    n_meuros.text = numeromeuros.ToString();
                    n_mac.text = q_maca.ToString();
                    compra_macas.name = "a";
                    venda = true;
                    PlayerPrefs.SetInt("numeromaca", q_maca);
                    PlayerPrefs.SetInt("numeromeuros", numeromeuros);
                }

                if (compra_noz.name == "acesso noz concedido" && numeromeuros >= 2)
                {
                    numeromeuros -= 2;
                    q_noz++;
                    n_meuros.text = numeromeuros.ToString();
                    n_n.text = q_noz.ToString();
                    compra_noz.name = "noz";
                    venda = true;
                    PlayerPrefs.SetInt("numeronoz", q_noz);
                    PlayerPrefs.SetInt("numeromeuros", numeromeuros);
                }

                if (compra_amora.name == "acesso amora concedido" && numeromeuros >= 3)
                {
                    numeromeuros -= 3;
                    q_amora++;
                    n_meuros.text = numeromeuros.ToString();
                    n_a.text = q_amora.ToString();
                    compra_amora.name = "amora";
                    venda = true;
                    PlayerPrefs.SetInt("numeroamora", q_amora);
                    PlayerPrefs.SetInt("numeromeuros", numeromeuros);
                }

                if (compra_groselha.name == "acesso groselha concedido" && numeromeuros >= 3)
                {
                    numeromeuros -= 3;
                    q_groselha++;
                    n_meuros.text = numeromeuros.ToString();
                    n_g.text = q_groselha.ToString();
                    compra_groselha.name = "groselha";
                    venda = true;
                    PlayerPrefs.SetInt("numerogroselha", q_groselha);
                    PlayerPrefs.SetInt("numeromeuros", numeromeuros);
                }

                if (compra_malagueta.name == "acesso malagueta concedido" && numeromeuros >= 13)
                {
                    numeromeuros -= 13;
                    q_malagueta++;
                    n_meuros.text = numeromeuros.ToString();
                    n_mal.text = q_malagueta.ToString();
                    compra_malagueta.name = "malagueta";

                    venda = true;
                    PlayerPrefs.SetInt("numeromeuros", numeromeuros);
                    PlayerPrefs.SetInt("numeromalagueta", q_malagueta);
                }

                if (compra_cenoura.name == "acesso cenoura concedido" && numeromeuros >= 20)
                {
                    numeromeuros -= 20;
                    q_cenoura++;
                    n_meuros.text = numeromeuros.ToString();
                    n_cen.text = q_cenoura.ToString();
                    venda = true;
                    compra_cenoura.name = "cenoura";
                    PlayerPrefs.SetInt("numerocenoura", q_cenoura);

                    PlayerPrefs.SetInt("numeromeuros", numeromeuros);
                }

                if (venda == false)
                {
                    PlayerPrefs.SetInt("venda", 0);
                }
                else
                {

                    PlayerPrefs.SetInt("venda", 1);
                }
            }
        }

        // VER INVENT�RIO, tamb�m, abre na loja
        if (inputController.GetPlayerInventario() 
            /*||*/
            /*d_robert<6.0f && inputController.GetPlayerItem()*/)
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
            imeuros.enabled = !imeuros.enabled;
            n_mal.enabled = !n_mal.enabled;
            imal.enabled = !imal.enabled;
            n_cen.enabled = !n_cen.enabled;
            icen.enabled = !icen.enabled;
            n_meuros.enabled = !n_meuros.enabled;
            n_meuros.text = numeromeuros.ToString();
            n_mac.text = q_maca.ToString();
            n_meuros.text = numeromeuros.ToString();
            n_n.text = q_noz.ToString();
            n_a.text = q_amora.ToString();
            n_g.text = q_groselha.ToString();
            n_mal.text = q_malagueta.ToString();
            n_cen.text = q_cenoura.ToString();
        }

        //// Troca de informa��o por cenouras
        //if (q_cenoura > 0) button_troca.interactable = true;
        //else button_troca.interactable = false;
    }

    // Apanhar os diversos itens
    public void ApanharItens(Collider[] item, float distance, int numero, Text texto_numero,string nome, string nome_msm)
    {
        for (int i = 0; i < item.Length; i++)
        {
            if (item[i] != null)
            {
                distance= Vector3.Distance(transform.position, item[i].transform.position);
                if (distance < 5.0f && inputController.GetPlayerItem())
                {
                    numero++;
                    texto_numero.text = numero.ToString();
                    item[i] = null;
                    PlayerPrefs.SetInt(nome, numero);
                }
            }
        }
    }

}
