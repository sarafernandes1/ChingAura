using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text texto_tutorial;
    public InputController inputController;
    private bool isInArea;
    public Canvas tutorial_canvas;

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
        if (other.tag == "Player" && !inputController.GetPlayerItem())
        {
            tutorial_canvas.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            tutorial_canvas.enabled = false;
        }
    }
}
