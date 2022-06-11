using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KironDialogos : MonoBehaviour
{
    public Canvas c1, c2, c3, c4, c5, c6, pedido, tem_itens, nao_tem_itens;
    public RawImage icon_npc, caixa_textbispoo, iconminku, icon_brito;
    public Text texto, bispo, texto_button, texto_minku, nome, nome_brito;
    public Button continuar_button, cb1, cb2, cb3, cb4, cb5, continuar;
    public InputController inputController;
    public Canvas mensagem;
    int desligar_mensagem = 0;
    public Collider minku;
    public RawImage fish, slime, bat;
    string[] dialogo_final;
    int index = 0;
    public Button escolha1, escolha2;
    int escolha;
    public Canvas vitoria, derrota;
    public Text e1, e2;

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        dialogo_final = new string[50];
        dialogo_final[0] = "Prazer em ver-te mais uma vez, Minku, ah, e Brito.\n" + "Hm, parece que, finalmente tens os três poderes. " +
            "E, agora, vens aqui, buscar a ching aura, hm, vamos ver se a consegues";
        dialogo_final[1] = "Claro, que eu a vou conseguir, Kiron, hoje, o nosso mundo vai voltar ao normal.";
        dialogo_final[2] = "Ahahahahaha, *tosse*. Bem, veremos isso";
        dialogo_final[3] = "Estou pronto, Kiron";
        dialogo_final[4] = "Ok, então, meu caro, eu dou-te a Ching Aura, se te livrares desse bicho";
        dialogo_final[5] = "Ei, unicórinio, eu tenho nome, sou o Brito";
        dialogo_final[6] = "Hm";
        dialogo_final[7] = "Minku? Tu não te vais livrar de mim, pois não? Minku, não.";


        bool tem_poderes=false;
        if(fish.enabled && slime.enabled && bat.enabled)
        {
            tem_poderes = true;
        }
        else
        {
            tem_poderes = false;
        }

        if (!tem_poderes)
        {
            desligar_mensagem = PlayerPrefs.GetInt("desligar_mensagemkiron");
            float distanceToMinku = Vector3.Distance(transform.position, minku.transform.position);

            if (inputController.GetPlayerItem() && desligar_mensagem == 0 && distanceToMinku < 6.0f)
            {
                c1.enabled = true;
            }

            if (c1.enabled && continuar_button.name == "continuar" && desligar_mensagem == 0)
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
                PlayerPrefs.SetInt("desligar_mensagemkiron", 1);
            }
        }

        float distanceToMinku1 = Vector3.Distance(transform.position, minku.transform.position);

        if (inputController.GetPlayerItem() && distanceToMinku1 > 6.0f && tem_poderes)
        {

            icon_npc.enabled = true;
            caixa_textbispoo.enabled = true;
            texto.enabled = true;
            bispo.enabled = true;
            texto_button.enabled = true;
            continuar.image.enabled = true;
            texto.text = dialogo_final[index];
        }

        if (caixa_textbispoo.enabled)
        {
            for (int j = 0; j < dialogo_final.Length; j++)
            {
                texto.text = dialogo_final[index];

                if (continuar.name == "continuar")
                {
                    index++;
                    if (index == 1 || index==3 || index==6)
                    {
                        iconminku.enabled = true;
                        icon_npc.enabled = false;
                        bispo.enabled = false;
                        nome.enabled = true;
                        icon_brito.enabled = false;
                        nome_brito.enabled = false;

                    }
                    if (index==0 || index==2 || index==4)
                    {
                        icon_brito.enabled = false;
                        iconminku.enabled = false;
                        icon_npc.enabled = true;
                        bispo.enabled = true;
                        nome.enabled = false;
                        nome_brito.enabled = false;

                    }

                    if (index == 5 || index == 7)
                    {
                        icon_brito.enabled = true;
                        iconminku.enabled = false;
                        icon_npc.enabled =false;
                        bispo.enabled = true;
                        nome.enabled = false;
                        nome_brito.enabled = true;
                    }

                    continuar.name = "a";
                    if (index >7)
                    {
                        iconminku.enabled = true;
                        icon_npc.enabled = false;
                        bispo.enabled = false;
                        nome.enabled = true;
                        caixa_textbispoo.enabled = true;
                        texto.enabled = true;
                        escolha1.image.enabled = true;
                        escolha2.image.enabled = true;
                        e1.enabled = true;
                        e2.enabled = true;
                        if (escolha == 1 || escolha == 2)
                        {
                            iconminku.enabled = false;
                            caixa_textbispoo.enabled = false;
                            texto.enabled = false;
                            icon_npc.enabled = false;
                            continuar.name = "a";
                            continuar.image.enabled = false;
                            bispo.enabled = false;
                            texto_button.enabled = false;
                            nome.enabled = false;
                            escolha1.image.enabled = false;
                            escolha2.image.enabled = false;
                            e1.enabled = false;
                            e2.enabled = false;
                        }
                        if (escolha == 1)
                        {
                            vitoria.enabled = true;
                        }
                        else if(escolha==2)
                        {
                            derrota.enabled = true;
                        }
                    }
                }

            }

         
        }

       


    }

    public void Continuar_final()
    {
        continuar.name = "continuar";
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

    public void Button1()
    {
        escolha = 1;
    }

    public void Button2()
    {
        escolha = 2;
    }
}
