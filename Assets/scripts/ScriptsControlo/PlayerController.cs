using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public InputController inputController;

    public float playerSpeed = 2.0f;
    public float jumpHeight = 1.0f;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float gravityValue = -9.81f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 playerInput = inputController.GetPlayerMoviment();

        transform.Rotate(Vector3.up, playerInput.x);

        Vector3 move = new Vector3(0, 0, playerInput.y);

        //move.z = w+s; move.x = a+d; forward = para onde estamos a olhar; right = movimento dos lados
        move = transform.forward * move.z;
        move.y = 0f;

        move.Normalize(); //para evitar movimento mais rápido na diagonal 

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
