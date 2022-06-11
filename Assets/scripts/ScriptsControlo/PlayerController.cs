using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Transform cameratransform;
    public InputController inputController;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 3.0f;
    public float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    private Vector3 moveDirection = Vector3.zero;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }


        Vector3 camRotation = cameratransform.eulerAngles;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
     
        Vector2 playermoviment = inputController.GetPlayerMoviment();
        Vector3 move = new Vector3(playermoviment.x, 0, playermoviment.y);
        move = transform.forward * move.z + transform.right * move.x;
        move.y = 0;
        move.Normalize();

        

        controller.Move(move * Time.deltaTime * playerSpeed);

        // Changes the height position of the player..
        if (inputController.GetPlayerJumpInThisFrame() && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
        
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

    }
}
