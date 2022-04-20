using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarNomeArea : MonoBehaviour
{
    public Text texto_nome;
    public bool isInArea, a=true;
    public string nome_do_sitio;
    public RawImage imagem;
    public float timer = 100.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isInArea && a)
        {
             texto_nome.enabled = true;
             imagem.enabled = true;
            timer-=0.7f;
            
            if (timer < 0 || !isInArea)
            {
                texto_nome.enabled = false;
                imagem.enabled = false;
                a = false;
                timer = 100;
            }

        }
        if (!isInArea && timer > 0.0f)
        {
            texto_nome.enabled = false;
            imagem.enabled = false;
            timer = 100;
        }
    }

    private void OnTriggerEnter(Collider other) //qd entra no trigger
    {
        if (other.tag == "Player")
        {
            isInArea = true;
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            isInArea = false;
            a = true;
        }
    }
}
