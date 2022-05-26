using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class door_controler : MonoBehaviour
{
    public GameObject minku;
    public Collider minku_collider;
    public Camera maincamera;
    public float distanceToCamera;
    public bool isInArea;
    public InputController inputController;
    public Button buttonimage;
    public Text textobutton;
    public Text numero_meuros;

    void Start()
    {
        Debug.Log("start");
    }

    void Update()
    {
    }

    //Pode ser chamado se o objeto onde o script está associado tiver um Collider com o isTrigger == true
    private void OnTriggerEnter(Collider other) //qd entra no trigger
    {
        if (other.tag == "Player" )
        {
            isInArea = true;
            buttonimage.image.enabled = true;
            textobutton.enabled = true; 
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            isInArea = false;
        }
    }
    public void IrparaTemplo()
    {
        SceneManager.LoadScene(2);
    }

    public void VoltarTemplo()
    {
        SceneManager.LoadScene(2);
    }

    public void VoltarVila()
    {
        SceneManager.LoadScene(1);
    }

    public void IrparaFloresta()
    {
        SceneManager.LoadScene(3);
    }
}
