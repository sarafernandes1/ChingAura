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
    public Text numero_meuros;
    public Canvas voltar, proxima;

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
          voltar.enabled = true;
           proxima.enabled = true; 
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            isInArea = false;
            voltar.enabled = false;
            proxima.enabled =false;
        }
    }
    public void LightFlorest()
    {
        SceneManager.LoadScene(1);
    }

    public void HovePlains()
    {
        SceneManager.LoadScene(2);
    }

    public void Goldencleek()
    {
        SceneManager.LoadScene(3);
    }

    public void DampeCave()
    {
        SceneManager.LoadScene(4);
    }

    public void Boss()
    {
        SceneManager.LoadScene(5);
    }
}
