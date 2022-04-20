using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public RawImage canvas_fundo;
    public Button continuar, sair, menu;
    public Text c_text, s_text, menu_text, pausa;
    public InputController inputController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (inputController.GetPlayerSairEsc())
        {
            canvas_fundo.enabled = true;
            continuar.image.enabled = true;
            sair.image.enabled =true;
            menu.image.enabled =true;
            c_text.enabled = true;
            s_text.enabled = true;
            menu_text.enabled = true;
            pausa.enabled =true;
            Time.timeScale = 0;
        }
    }

    public void ContinuarJogo()
    {
        pausa.enabled = false;
        canvas_fundo.enabled = false;
        continuar.image.enabled = false;
        sair.image.enabled = false;
        menu.image.enabled = false;
        c_text.enabled = false;
        s_text.enabled = false;
        menu_text.enabled = false;
        Time.timeScale = 1;
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Sair()
    {
        Application.Quit();
        Time.timeScale = 1;
    }
}

