using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoBispo : MonoBehaviour
{
    public RawImage icon_npc,caixa_textbispoo, iconminku;
    public Text texto, bispo, texto_button, texto_minku, nome;
    public Collider npc, jogador;
    public InputController inputController;
    private float distancetoNPC;
    private string[] dialogos, primerio_dialogo;
    public Button continuar;
    public int index = 0;
    bool tem_materiais=false;
    int n_dialogo = 0;
    bool tem_fragmento = false;
    public Canvas canvas;
    string poder_adquirido;

    void Start()
    {
    }

    void Update()
    {
        poder_adquirido = PlayerPrefs.GetString("poder");
        n_dialogo = PlayerPrefs.GetInt("ndialogo");
        if (PlayerPrefs.GetInt("numeromaca") >= 1)
        {
            tem_materiais = true;
        }
        if (PlayerPrefs.GetInt("numeromaca") <= 0)
        {
            tem_materiais = false;
        }

        dialogos = new string[7];
        primerio_dialogo = new string[7];
        dialogos[0] = "Hoho!! Ol� Minku \n" +
            "Encontraste pistas da localiza��o do ladr�o e da ching aura?";
        dialogos[1] = "Hoho! Um fragmento de ching aura \n" +
            "Parece ser ho poder de "+ poder_adquirido +", se quiseres eu posso fazer com que\n" +
            "consigas hosar ho poder, s� precisamos de halgumas coisinhas";
        dialogos[2] = "Hoho, j� tens os materiais?";
        dialogos[3] = "Ent�o vamos come�ar";
        dialogos[4] = "Hm, parece que te faltam alguns materiais";
        if (poder_adquirido == "PoderFish")
        {
            dialogos[5] = "Materiais em falta: 1 cenoura dourada e 2 ma��s";
        }
        if (poder_adquirido == "poderslime")
        {
            dialogos[5] = "Materiais em falta: 1 cenoura dourada, 1 noz, 3 ma��s e 2 amoras";
        }
        if (poder_adquirido == "poderpeixe")
        {
            dialogos[5] = "Materiais em falta: 1 cenoura dourada, 1 noz, 1 morangoe e 2 ma��s";
        }

        dialogos[6] = "Hm, sem pistas por hagora \n" +
            "se encontares halgo, n�o te esque�as de havisar";

        primerio_dialogo[0] = "Hoho, minku, ainda bem que aqui vens\n" +
            "Algo de terrivel aconteceu";
        primerio_dialogo[1] = "Kiron, roubou a Ching Aura!!!!!";
        primerio_dialogo[2] = "Agora precisamos de algu�m que consiga os tr�s poderes e, que depois enfrete-o";
        primerio_dialogo[3] = "Ao menos, se houvesse algu�m, lutador e corajoso para fazer isso";
        primerio_dialogo[4] = "Meu deus, l� vem a tipica fala de quando se precisa de um her�i. Ogho eu fa�o isso, afinal, sou o �nico personagem que anda por a�.";
        primerio_dialogo[5] = "Fazias isso por todos n�s? \n" +
            "Muito obrigado, meu Minku, quando conquistares um poder, vem aqui\n" +
            "Boa sorte, nosso her�i";

        distancetoNPC = Vector3.Distance(npc.transform.position, jogador.transform.position);
        if (distancetoNPC < 12.0f && inputController.GetPlayerItem() && (poder_adquirido == "PoderFish" || n_dialogo==0))
        {
            icon_npc.enabled = true;
            caixa_textbispoo.enabled = true;
            texto.enabled = true;
            bispo.enabled = true;
            texto_button.enabled = true;
            continuar.image.enabled = true;
        }

        if (texto.enabled && n_dialogo==0)
        {
            for (int j = 0; j < primerio_dialogo.Length; j++)
            {
              
                   texto.text = primerio_dialogo[index];

                    if (continuar.name == "continuar")
                    {
                        index++;
                    if (index == 4)
                    {
                        iconminku.enabled = true;
                        icon_npc.enabled = false;
                        bispo.enabled = false;
                        nome.enabled = true;
                    }
                    else
                    {
                        iconminku.enabled = false;
                        icon_npc.enabled = true;
                        bispo.enabled = true;
                        nome.enabled = false;
                    }
                        continuar.name = "a";
                        if (index >= 6)
                        {
                            index = 0;
                            caixa_textbispoo.enabled = false;
                            texto.enabled = false;
                            icon_npc.enabled = false;
                            continuar.name = "a";
                            continuar.image.enabled = false;
                            bispo.enabled = false;
                            texto_button.enabled = false;
                             PlayerPrefs.SetInt("ndialogo", 1);
                        }
                    }
                
            }
        }

        if (texto.enabled && n_dialogo==1 && poder_adquirido == "PoderFish")
        {
            for (int j = 0; j < dialogos.Length; j++)
            {
                if (index < 7)
                {
                    //if (index == 5) texto.text= dialogos[index] + " 1 ma��";
                    //else  texto.text = dialogos[index];
                    texto.text = dialogos[index];
                    if (continuar.name == "continuar")
                    {
                        index++;
                        if (tem_materiais && index==2) index = 3;
                        else if(!tem_materiais && index==2) index = 4;
                        continuar.name = "a";
                        if (index >= 6 || index==4 && tem_materiais)
                        {
                            index = 0;
                            caixa_textbispoo.enabled = false;
                            texto.enabled = false;
                            icon_npc.enabled = false;
                            continuar.name = "a";
                            continuar.image.enabled = false;
                            bispo.enabled = false;
                            texto_button.enabled = false;
                            PlayerPrefs.SetString("PoderFish", "true");
                        }
                    }
                }
            }
        }

    }

    public void Continuar()
    {
        continuar.name = "continuar";
    }

    private void OnTriggerEnter(Collider other) //qd entra no trigger
    {
        if (other.tag == "Player" && poder_adquirido != "PoderFish" && n_dialogo==1)
        {
            canvas.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            canvas.enabled = false;
        }
    }

}
