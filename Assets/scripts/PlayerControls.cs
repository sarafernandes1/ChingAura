// GENERATED AUTOMATICALLY FROM 'Assets/scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""820f9df4-1888-4eaa-aa25-8e83bd07e9a1"",
            ""actions"": [
                {
                    ""name"": ""Moviment"",
                    ""type"": ""Value"",
                    ""id"": ""8f137bbf-ac85-4aa8-94ca-31175a5c742d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""eb9b61c4-556c-4077-873e-4e83ab0e9927"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""4dfb1b5a-76d6-4dc2-afde-349fde72cf2c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GetItem"",
                    ""type"": ""Button"",
                    ""id"": ""297e6684-fdc6-44a6-a907-846941b7c0ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventario"",
                    ""type"": ""Button"",
                    ""id"": ""8ad959f4-08e4-45e2-95ee-ec4186ae94f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SairEsc"",
                    ""type"": ""Button"",
                    ""id"": ""13c1d63e-8e17-453d-b60d-d607cc39fb39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ProximoDialogo"",
                    ""type"": ""Button"",
                    ""id"": ""74613a2c-a2bc-4b98-ba23-78cf53390e21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""df5dbb91-b812-4654-a2ec-1fe672ecaced"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moviment"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0c47770e-be77-448b-920e-c494a700b857"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moviment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""62b73c57-00c9-4c4e-a69e-67e75a6319d0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moviment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1b4ac862-0602-4567-a207-93ccb9029ec6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moviment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e90c6840-e195-4347-8218-e69d7ad10149"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moviment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""252018a9-11d4-45ec-9751-aa2b22755615"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7e44272-f622-4a91-b979-7bfc6a462328"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6826bea-9892-4e89-9eac-18454b2f4a8e"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65f1a929-ab74-4a0b-a03b-405983ad9fac"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventario"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d012e40-0bbb-4f1f-b9db-3854bc8e084d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SairEsc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef712ba4-adda-4ae2-97d2-b9758e143aa2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ProximoDialogo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Moviment = m_Player.FindAction("Moviment", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_GetItem = m_Player.FindAction("GetItem", throwIfNotFound: true);
        m_Player_Inventario = m_Player.FindAction("Inventario", throwIfNotFound: true);
        m_Player_SairEsc = m_Player.FindAction("SairEsc", throwIfNotFound: true);
        m_Player_ProximoDialogo = m_Player.FindAction("ProximoDialogo", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Moviment;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_GetItem;
    private readonly InputAction m_Player_Inventario;
    private readonly InputAction m_Player_SairEsc;
    private readonly InputAction m_Player_ProximoDialogo;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moviment => m_Wrapper.m_Player_Moviment;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @GetItem => m_Wrapper.m_Player_GetItem;
        public InputAction @Inventario => m_Wrapper.m_Player_Inventario;
        public InputAction @SairEsc => m_Wrapper.m_Player_SairEsc;
        public InputAction @ProximoDialogo => m_Wrapper.m_Player_ProximoDialogo;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Moviment.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoviment;
                @Moviment.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoviment;
                @Moviment.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoviment;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @GetItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGetItem;
                @GetItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGetItem;
                @GetItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGetItem;
                @Inventario.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventario;
                @Inventario.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventario;
                @Inventario.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventario;
                @SairEsc.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSairEsc;
                @SairEsc.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSairEsc;
                @SairEsc.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSairEsc;
                @ProximoDialogo.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnProximoDialogo;
                @ProximoDialogo.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnProximoDialogo;
                @ProximoDialogo.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnProximoDialogo;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Moviment.started += instance.OnMoviment;
                @Moviment.performed += instance.OnMoviment;
                @Moviment.canceled += instance.OnMoviment;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @GetItem.started += instance.OnGetItem;
                @GetItem.performed += instance.OnGetItem;
                @GetItem.canceled += instance.OnGetItem;
                @Inventario.started += instance.OnInventario;
                @Inventario.performed += instance.OnInventario;
                @Inventario.canceled += instance.OnInventario;
                @SairEsc.started += instance.OnSairEsc;
                @SairEsc.performed += instance.OnSairEsc;
                @SairEsc.canceled += instance.OnSairEsc;
                @ProximoDialogo.started += instance.OnProximoDialogo;
                @ProximoDialogo.performed += instance.OnProximoDialogo;
                @ProximoDialogo.canceled += instance.OnProximoDialogo;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMoviment(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnGetItem(InputAction.CallbackContext context);
        void OnInventario(InputAction.CallbackContext context);
        void OnSairEsc(InputAction.CallbackContext context);
        void OnProximoDialogo(InputAction.CallbackContext context);
    }
}
