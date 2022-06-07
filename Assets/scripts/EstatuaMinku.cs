using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstatuaMinku : MonoBehaviour
{
    public Collider[] objetos_da_estatua;
    public Collider estatua;
    private float distance, distanceToEstatua;
    public InputController inputController;
    private int numero = 0;
    public MeshRenderer m1, m2, cubo_ativarestatua;
    public GameObject gold;
    public AudioSource audio_estatua;
    public Canvas estatua_canvas, itens_coletados_canvas;

    void Start()
    {

    }

    void Update()
    {
        if(PlayerPrefs.GetString("estatuacoletada") == "completado"){
            m1.enabled = true;
            m2.enabled = true;
            cubo_ativarestatua.enabled = true;
        }

        //apnanha pista
        //depois, tem que encontrar os dois elementos que a estatua estava a segurar
        for (int i = 0; i < objetos_da_estatua.Length; i++)
        {
            if (objetos_da_estatua[i] != null)
            {
                distance = Vector3.Distance(transform.position, objetos_da_estatua[i].transform.position);
                if (distance < 5.0f && inputController.GetPlayerItem())
                {
                    numero++;
                    objetos_da_estatua[i] = null;
                    PlayerPrefs.SetInt("musicaobjeto", numero);
                }
            }
        }

        if (numero == 2)
        {
            cubo_ativarestatua.enabled = true;
        }

        // ao fim, tem que lá por e recebe 20 meuros

        float distanceToCubo = Vector3.Distance(transform.position, cubo_ativarestatua.transform.position);
        distanceToEstatua = Vector3.Distance(transform.position, estatua.transform.position);
        if (PlayerPrefs.GetInt("musicaobjeto") == 2 && distanceToCubo < 4.0f && inputController.GetPlayerItem() 
            && m1!=null && m2!=null && gold!=null)
        {
            m1.enabled = true;
            m2.enabled = true;
            gold.SetActive(true);
            PlayerPrefs.SetString("estatuacoletada", "completado");
        }

        if (gold != null)
        {
            distance = Vector3.Distance(transform.position, gold.transform.position);
            if (distance < 3.0f && inputController.GetPlayerItem() &&  PlayerPrefs.GetString("estatuacoletada")== "completado")
            {
                numero = 20;
                gold = null;
                PlayerPrefs.SetInt("numeromeuros", numero);
            }
        }
    }
}
