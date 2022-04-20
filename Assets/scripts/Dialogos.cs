using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogos : MonoBehaviour
{
    public RawImage icon_minku, icon_npc, caixa_textominku, caixa_textobrito;
    public Text texto,minku, brito, texto_button;
    public Collider npc, jogador;
    public InputController inputController;
    private float distancetoNPC;
    private string[] dialogos;
    public Button continuar;
    int i=0;
    bool dialogo_fim;

    void Start()
    {
    }

    void Update()
    {
        dialogos = new string[2];
        dialogos[0] = "Olá, estas são as teclas:\n WASD- andar \t X- interagir \n I- Inventário \t ESC- Pausa";
        dialogos[1] = "Olá e obrigado";
        distancetoNPC = Vector3.Distance(npc.transform.position, jogador.transform.position);
        if (distancetoNPC < 3.0f && inputController.GetPlayerItem() && !dialogo_fim)
        {
            caixa_textobrito.enabled = true;
            texto.enabled = true;
            minku.enabled = true;
            brito.enabled = true;
            texto_button.enabled = true;
            continuar.image.enabled = true;
        }

        if (texto.enabled)
        {
            for (int j = 0; j < dialogos.Length; j++)
            {
                if (i < 2)
                {
                    texto.text = dialogos[i];
                    if (i % 2 != 0)
                    {
                        caixa_textominku.enabled = true;
                        caixa_textobrito.enabled=false;
                        icon_minku.enabled = true;
                        icon_npc.enabled = false;
                        minku.enabled = true;
                        brito.enabled = false;
                    }
                    else
                    {
                        caixa_textominku.enabled =false;
                        caixa_textobrito.enabled = true;
                        icon_npc.enabled = true;
                        icon_minku.enabled = false;
                        minku.enabled = false;
                        brito.enabled = true;
                    }

                    if (continuar.name == "continuar")
                    {
                        i++;
                        continuar.name = "a";
                        if (i >= 2)
                        {
                            caixa_textominku.enabled = false;
                            texto.enabled = false;
                            icon_npc.enabled = false;
                            icon_minku.enabled = false;
                            continuar.name = "a";
                            continuar.image.enabled = false;
                            dialogo_fim = true;
                            minku.enabled = false;
                            brito.enabled = false;
                            texto_button.enabled = false;
                        }
                    }
                }
            }
        }

    }

    public void Continuar()
    {
        continuar.name= "continuar";
    }
      

}
