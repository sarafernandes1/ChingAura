using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestaoPedidos : MonoBehaviour
{
    public Canvas pedido1, pedido2, pedido3;
    public Canvas pedido1completado, pedido2completado, pedido3completado;
    public InputController inputController;

    int n_tab = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputController.AcederPedido())
        {
            if(PlayerPrefs.GetString("pedido1") == "registado" && PlayerPrefs.GetString("pedido1")!="completado") pedido1.enabled = !pedido1.enabled;
            if (PlayerPrefs.GetString("pedido2") == "registado" && PlayerPrefs.GetString("pedido2") != "completado") pedido2.enabled = !pedido2.enabled;
            if (PlayerPrefs.GetString("pedido3") == "registado" && PlayerPrefs.GetString("pedido3") != "completado") pedido3.enabled = !pedido3.enabled;
            if ( PlayerPrefs.GetString("pedido1") == "completado") pedido1completado.enabled = !pedido1completado.enabled;
            if ( PlayerPrefs.GetString("pedido2") == "completado") pedido2completado.enabled = !pedido2completado.enabled;
            if ( PlayerPrefs.GetString("pedido3") == "completado") pedido3completado.enabled = !pedido3completado.enabled;
        }

       
      
    }
}
