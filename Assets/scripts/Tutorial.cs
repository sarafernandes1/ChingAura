using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text texto_tutorial;
    public InputController inputController;
    private bool isInArea;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputController.GetPlayerItem())
        {
            texto_tutorial.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other) //qd entra no trigger
    {
        if (other.tag == "Player" && !inputController.GetPlayerItem())
        {
            isInArea = true;
            texto_tutorial.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            isInArea = false;
            texto_tutorial.enabled = false;
        }
    }
}
