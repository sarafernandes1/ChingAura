using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private PlayerControls _playerControls;

    // Start is called before the first frame update
    void Awake()
    {
        _playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        _playerControls.Enable();
    }

    public Vector2 GetPlayerMoviment()
    {
        return _playerControls.Player.Moviment.ReadValue<Vector2>();
    }

    public bool GetPlayerJumpInThisFrame()
    {
        return _playerControls.Player.Jump.triggered;
    }

    public Vector2 GetPlayerLook()
    {
        return _playerControls.Player.Look.ReadValue<Vector2>();
    }

    public bool GetPlayerItem()
    {
        return _playerControls.Player.GetItem.triggered;
    }

    public bool GetPlayerInventario()
    {
        return _playerControls.Player.Inventario.triggered;
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }
}
