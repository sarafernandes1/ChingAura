using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoBispo : MonoBehaviour
{
    public RawImage icon_npc,caixa_textbispoo;
    public Text texto, bispo, texto_button;
    public Collider npc, jogador;
    public InputController inputController;
    private float distancetoNPC;
    private string[] dialogos;
    public Button continuar;
    public int index = 0;
    bool tem_materiais=false;

    void Start()
    {
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("numeromaca") >= 1)
        {
            tem_materiais = true;
        }
        if (PlayerPrefs.GetInt("numeromaca") <= 0)
        {
            tem_materiais = false;
        }

        dialogos = new string[7];
        dialogos[0] = "Hoho!! Ol� Minku \n" +
            "Encontraste pistas da localiza��o do ladr�o e da ching aura?";
        dialogos[1] = "Hoho! Um fragmento de ching aura \n" +
            "Parece ser ho poder de ... se quiseres eu posso fazer com que\n" +
            "consigas hosar ho poder, s� precisamos de halgumas coisinhas";
        dialogos[2] = "Hoho, j� tens os materiais?";
        dialogos[3] = "Ent�o vamos come�ar";
        dialogos[4] = "Hm, parece que te faltam alguns materiais";
        dialogos[5] = "Materiais em falta: ";
        dialogos[6] = "Hm, sem pistas por hagora \n" +
            "se encontares halgo, n�o te esque�as de havisar";

        distancetoNPC = Vector3.Distance(npc.transform.position, jogador.transform.position);
        if (distancetoNPC < 12.0f && inputController.GetPlayerItem())
        {
            icon_npc.enabled = true;
            caixa_textbispoo.enabled = true;
            texto.enabled = true;
            bispo.enabled = true;
            texto_button.enabled = true;
            continuar.image.enabled = true;
        }

        if (texto.enabled)
        {
            for (int j = 0; j < dialogos.Length; j++)
            {
                if (index < 7)
                {
                   if (index == 5) texto.text= dialogos[index] + " 1 ma��";
                   else  texto.text = dialogos[index];
                   
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

}
