using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door_controler : MonoBehaviour
{
    public Animator animator;
    public AudioSource audio;
    public Collider minku;
    public float distanceToCamera;
    public bool isInArea;
    public InputController inputController;

    void Start()
    {
        Debug.Log("start");
    }

    void Update()
    {
        distanceToCamera = Vector3.Distance(transform.position, minku.transform.position);
        if (inputController.GetPlayerItem() && distanceToCamera<2.0f)
        {
            bool doorState = animator.GetBool("door_open");
            audio.mute = false;
            if (doorState)
            {
                animator.SetBool("door_open", false);
                audio.Play();
            }
            else
            {
                audio.Play();
                animator.SetBool("door_open", true);
            }
        }
    }

    //Pode ser chamado se o objeto onde o script está associado tiver um Collider com o isTrigger == true
    private void OnTriggerEnter(Collider other) //qd entra no trigger
    {
        if (other.tag == "Player" )
        {
            isInArea = true;
        }
    }

    private void OnTriggerExit(Collider other) //qd sai do trigger
    {
        if (other.tag == "Player")
        {
            isInArea = false;
        }
    }
}
