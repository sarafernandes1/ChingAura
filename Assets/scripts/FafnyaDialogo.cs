using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FafnyaDialogo : MonoBehaviour
{
    public Canvas c1, c2, c3, c4, c5, c6, pedido, tem_itens, nao_tem_itens;
    public Button continuar_button, cb1, cb2, cb3, cb4, cb5;
    public InputController inputController;
    public Canvas mensagem;
    float timer = 10.0f;
    int desligar_mensagem = 0;
    public Collider minku;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        desligar_mensagem = PlayerPrefs.GetInt("desligar");
        float distanceToMinku = Vector3.Distance(transform.position, minku.transform.position);
        if(distanceToMinku<6.0f && inputController.GetPlayerItem() && desligar_mensagem==0)
        {
            c1.enabled = true;
        }

        if (c1.enabled && continuar_button.name == "continuar")
        {
            c2.enabled = true;
            c1.enabled = false;
            continuar_button.name = "a";
        }

        if (cb1.name == "continuar")
        {
            cb1.name = "a";
            c3.enabled = true;
            c2.enabled = false;
            c1.enabled = false;

        }

        if (cb2.name == "continuar")
        {
            cb2.name = "a";
            c4.enabled = true;
            c3.enabled = false;
            c2.enabled = false;


        }

        if (cb3.name == "continuar")
        {
            cb3.name = "a";
            c5.enabled = true;
            c4.enabled = false;

        }

        if (c5.enabled && cb4.name == "continuar")
        {
            c5.enabled = false;
            c4.enabled = false;
            cb3.name = "a";
            PlayerPrefs.SetInt("desligar",1);
            PlayerPrefs.SetString("pedido2", "registado");
        }


        if (inputController.AcederPedido() && PlayerPrefs.GetString("fafnyaitens") != "tem")
        {
            c6.enabled = false;
        }

        if (inputController.GetPlayerItem() && PlayerPrefs.GetString("fafnyaitens") != "tem" && desligar_mensagem == 1 && distanceToMinku < 6.0f)
        {
            nao_tem_itens.enabled = !nao_tem_itens.enabled;
        }
        if (inputController.GetPlayerItem() && PlayerPrefs.GetString("fafnyaitens") == "tem" && distanceToMinku < 6.0f)
        {
            tem_itens.enabled = true;
            PlayerPrefs.SetString("pedido2", "completado");
            if (inputController.GetPlayerItem())
            {
                tem_itens.enabled = false;
            }
        }
    }

    public void Continuar()
    {
        continuar_button.name = "continuar";
    }

    public void Continuar1()
    {
        cb1.name = "continuar";
    }

    public void Continuar2()
    {
        cb2.name = "continuar";
    }

    public void Continuar3()
    {
        cb3.name = "continuar";
    }

    public void Continuar4()
    {
        cb4.name = "continuar";
    }

    public void Continuar5()
    {
        cb5.name = "continuar";
    }
}
