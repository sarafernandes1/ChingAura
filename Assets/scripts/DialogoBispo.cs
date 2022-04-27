using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoBispo : MonoBehaviour
{
    public RawImage icon_minku, icon_npc, caixa_textominku, caixa_textobrito;
    public Text texto, minku, brito, texto_button;
    public Collider npc, jogador;
    public InputController inputController;
    private float distancetoNPC;
    private string[] dialogos;
    public Button continuar;
    int i = 0;
    bool dialogo_fim;

    void Start()
    {
    }

    void Update()
    {
        dialogos = new string[2];
        dialogos[0] = "Hoho!! Olá Minku \n" +
            "Encontraste pistas da localização do ladrão e da ching aura?";
        dialogos[1] = "Hoho! Um fragmento de ching aura \n" +
            "Parece ser ho poder de ... se quiseres eu posso fazer com que\n" +
            "consigas hosar ho poder, só precisamos de halgumas coisinhas";
        dialogos[2] = "Hoho, já tens os materiais?";
        dialogos[3] = "Então vamos começar";
        dialogos[4] = "Hm, parece que te faltam alguns materiais";
        dialogos[5] = "Materiais em falta: ";
        dialogos[6] = "Hm, sem pistas por hagora \n" +
            "se encontares halgo, não te esqueças de havisar";

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

        }

    }

    public void Continuar()
    {
        continuar.name = "continuar";
        PlayerPrefs.SetInt("inventarioloja", 0);
    }

}
