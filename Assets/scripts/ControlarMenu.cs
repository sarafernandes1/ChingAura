using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlarMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Torna o rato visivel; o controlador em primeira pessoa desativa o rato
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NewGameClick() //fun��o a ser chamada atarv�s do inspector do Bot�o (ver Button na Scene)
    {
        Debug.Log("new game click");
        Cursor.visible = false;
        SceneManager.LoadScene(1); //SceneManager.LoadScene("SampleScene"); //faz load de uma nova Scene
    }

    public void ExitClick() //fun��o a ser chamada atarv�s do inspector do Bot�o (ver Button (1) na Scene)
    {
        Debug.Log("exit click");
        Application.Quit(); //Fecha a aplica��o; n�o corre no editor
    }
}
