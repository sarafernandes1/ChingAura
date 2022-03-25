using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_ZorriEsquilo : MonoBehaviour
{
    public Collider minku;
    public float distancetoMinku;
    public InputController inputController;
    public RawImage fundo;
    public Text m, n, a, g, c, mal, buttontext, bt2;
    public CharacterController characterController;
    public Button comprar, comprar2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
;        distancetoMinku = Vector3.Distance(transform.position, minku.transform.position);
        if(distancetoMinku<3.0f && inputController.GetPlayerItem())
        {
            //characterController.enabled = false;
            fundo.enabled = !fundo.enabled;
            m.enabled = !m.enabled;
            n.enabled = !n.enabled;
            a.enabled = !a.enabled;
            g.enabled = !g.enabled;
            c.enabled = !c.enabled;
            mal.enabled = !mal.enabled;
            comprar.image.enabled = !comprar.image.enabled;
            buttontext.enabled = !buttontext.enabled;
            comprar2.image.enabled = !comprar2.image.enabled;
            comprar2.enabled = !comprar2.enabled;
            bt2.enabled = !bt2.enabled;
        }

    }

    public void ComprarMaca() 
    {
        Debug.Log("compra");
        comprar.name = "acesso concedido";
    }
}
