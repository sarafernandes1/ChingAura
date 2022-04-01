using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogos : MonoBehaviour
{
    public RawImage icon_minku, icon_npc, caixa_texto;
    public Text texto, texto_2, t3;
    public Collider npc, jogador;
    public InputController inputController;
    private float distancetoNPC;
    private string[] dialogos;
    public Button continuar;
    int i=0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        dialogos = new string[2];
        dialogos[0] = "Ola";
        dialogos[1] = "ola";
        distancetoNPC = Vector3.Distance(npc.transform.position, jogador.transform.position);
        if (distancetoNPC < 3.0f && inputController.GetPlayerItem())
        {
            caixa_texto.enabled = true;
            texto.enabled = true;
            texto_2.enabled = true;
            continuar.image.enabled = true;
            t3.enabled = true;
        }

        if (texto.enabled)
        {
            for (int j = 0; j < 2; j++)
            {
                if (i < 2)
                {
                    texto.text = dialogos[i];
                    if (i % 2 == 0)
                    {
                        icon_minku.enabled = true;
                        icon_npc.enabled = false;
                    }
                    else
                    {
                        icon_npc.enabled = true;
                        icon_minku.enabled = false;
                    }

                    if (continuar.name == "continuar")
                    {
                        i++;
                        continuar.name = "a";
                        if (i >= 2)
                        {
                            caixa_texto.enabled = false;
                            texto.enabled = false;
                            texto_2.enabled = false;
                            icon_npc.enabled = false;
                            icon_minku.enabled = false;
                            continuar.name = "a";
                            continuar.image.enabled = false;

                            t3.enabled = false;
                        }
                    }
                }
            }
        }

    }
      

}
