using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraOnOff : MonoBehaviour
{
    public Collider npc1, npc2, jogador;
    public float distanceto1, distanceto2;
    public Cinemachine.CinemachineVirtualCamera virtualCamera;
    public InputController inputController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceto1 = Vector3.Distance(jogador.transform.position, npc1.transform.position);
        distanceto2 = Vector3.Distance(jogador.transform.position, npc2.transform.position);
        if(distanceto1<2.0f)
        {
            virtualCamera.enabled = false; 
        }
        else if (distanceto2 < 2.0f)
        {
            virtualCamera.enabled = false;
        }
        else 
        {
            virtualCamera.enabled = true;
        }
    }
}
