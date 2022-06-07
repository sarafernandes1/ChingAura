using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text texto_tutorial;
    public InputController inputController;
    private bool isInArea;
    public Button continuar;
    public Canvas tutorial_canvas, fim_dialogo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other) //qd entra no trigger
    {
        if (other.tag == "Player" && continuar.name!="a")
        {
            tutorial_canvas.enabled = true;
        }

        if (other.tag == "Player" && continuar.name == "a")
        {
            tutorial_canvas.enabled = false;
            fim_dialogo.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            fim_dialogo.enabled = false;
            tutorial_canvas.enabled = false;
        }
    }
}
