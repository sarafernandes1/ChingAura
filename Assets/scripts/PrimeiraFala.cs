using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrimeiraFala : MonoBehaviour
{
    int n_fala = 0;
    public Canvas falas_minku;

    void Start()
    {

    }

    void Update()
    {
        n_fala = PlayerPrefs.GetInt("fala");
    }

    private void OnTriggerEnter(Collider other) //qd entra no trigger
    {
        if (other.tag == "Player" && n_fala==0)
        {
            falas_minku.enabled = true;
            PlayerPrefs.SetInt("fala", 1);
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            falas_minku.enabled = false;
        }
    }
}
