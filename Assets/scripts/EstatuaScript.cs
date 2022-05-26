using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstatuaScript : MonoBehaviour
{
    public Canvas estatua_canvas, itens_coletados_canvas, enigma_completado;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) //qd entra no trigger
    {
        if (other.tag == "Player")
        {
            if (PlayerPrefs.GetInt("musicaobjeto") == 2)
            {
                itens_coletados_canvas.enabled = true;
            }
            else estatua_canvas.enabled = true;

            if(PlayerPrefs.GetString("estatuacoletada")== "completado")
            {
                itens_coletados_canvas.enabled = false;
                estatua_canvas.enabled = false;
                enigma_completado.enabled = true;
            }
            
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            estatua_canvas.enabled = false;
            itens_coletados_canvas.enabled = false;
            enigma_completado.enabled = false;
        }
    }
}
