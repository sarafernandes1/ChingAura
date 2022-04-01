using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SairJogopeloEsc : MonoBehaviour
{
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
            SceneManager.LoadScene(0);
        }
    }
}
