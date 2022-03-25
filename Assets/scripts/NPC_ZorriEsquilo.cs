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
    public Text m,n,a,g,c,mal;
    public CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancetoMinku = Vector3.Distance(transform.position, minku.transform.position);
        if(distancetoMinku<5.0f && inputController.GetPlayerItem())
        {
            characterController.enabled = false;
            fundo.enabled = !fundo.enabled;
            m.enabled = !m.enabled;
            n.enabled = !n.enabled;
            a.enabled = !a.enabled;
            g.enabled = !g.enabled;
            c.enabled = !c.enabled;
            mal.enabled = !mal.enabled;
        }

        if (!m.enabled)
        {
            characterController.enabled = true;
        }
    }
}
