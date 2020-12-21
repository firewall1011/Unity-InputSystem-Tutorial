// GENERATED AUTOMATICALLY FROM 'Assets/Aula/AulaActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @AulaActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @AulaActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""AulaActions"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""9a458c13-71e8-4615-b4c7-0034d868f0a8"",
            ""actions"": [
                {
                    ""name"": ""Atirar"",
                    ""type"": ""Button"",
                    ""id"": ""2b4aaeb6-b70f-47a0-9b68-a1b8b6318595"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SuperAtirar"",
                    ""type"": ""Button"",
                    ""id"": ""d1a21350-ef7c-44ac-b687-56894489bfe0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=1)""
                },
                {
                    ""name"": ""Rotacionar"",
                    ""type"": ""Value"",
                    ""id"": ""2f381438-8b56-4cf7-b920-5e88d45dbd46"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mover"",
                    ""type"": ""Value"",
                    ""id"": ""7e92c66a-e598-4913-b219-aad5c03a0996"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9c201883-aa13-41ce-b735-6992df2f019f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Atirar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89e9e2e9-c758-4004-ba67-831612c54b7f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Atirar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47301131-709a-4211-9148-d41fd1c7ec97"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotacionar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Setas"",
                    ""id"": ""c74cc6fa-8ae4-4036-a547-fb35de40f4c2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotacionar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""04d95045-4f88-4452-bcb4-926c22e48c9f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotacionar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a31a134b-d446-4b10-9b01-4c63c9dba981"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotacionar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""64b07339-8723-43b2-9fb6-8cef20acd5b7"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""210a9d67-3407-4262-bbe3-06215066dde8"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""7ac774ed-7058-4ee7-8bd6-c0b13ca48572"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b45857e1-f777-497e-9baf-aafabdb64551"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2fdfcdcb-57bf-4bfb-9c02-54355680d282"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bd754dbc-6efe-4186-947f-63177be204ac"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ceab1bda-9e4d-4038-8718-7754fceb1699"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b25add02-d7ba-48d0-bda3-1b5cda6904a9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SuperAtirar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac0d3922-88ba-4830-a718-d06bc94e5244"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SuperAtirar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // gameplay
        m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
        m_gameplay_Atirar = m_gameplay.FindAction("Atirar", throwIfNotFound: true);
        m_gameplay_SuperAtirar = m_gameplay.FindAction("SuperAtirar", throwIfNotFound: true);
        m_gameplay_Rotacionar = m_gameplay.FindAction("Rotacionar", throwIfNotFound: true);
        m_gameplay_Mover = m_gameplay.FindAction("Mover", throwIfNotFound: true);
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

    // gameplay
    private readonly InputActionMap m_gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_gameplay_Atirar;
    private readonly InputAction m_gameplay_SuperAtirar;
    private readonly InputAction m_gameplay_Rotacionar;
    private readonly InputAction m_gameplay_Mover;
    public struct GameplayActions
    {
        private @AulaActions m_Wrapper;
        public GameplayActions(@AulaActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Atirar => m_Wrapper.m_gameplay_Atirar;
        public InputAction @SuperAtirar => m_Wrapper.m_gameplay_SuperAtirar;
        public InputAction @Rotacionar => m_Wrapper.m_gameplay_Rotacionar;
        public InputAction @Mover => m_Wrapper.m_gameplay_Mover;
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Atirar.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtirar;
                @Atirar.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtirar;
                @Atirar.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAtirar;
                @SuperAtirar.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSuperAtirar;
                @SuperAtirar.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSuperAtirar;
                @SuperAtirar.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSuperAtirar;
                @Rotacionar.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotacionar;
                @Rotacionar.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotacionar;
                @Rotacionar.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotacionar;
                @Mover.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMover;
                @Mover.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMover;
                @Mover.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMover;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Atirar.started += instance.OnAtirar;
                @Atirar.performed += instance.OnAtirar;
                @Atirar.canceled += instance.OnAtirar;
                @SuperAtirar.started += instance.OnSuperAtirar;
                @SuperAtirar.performed += instance.OnSuperAtirar;
                @SuperAtirar.canceled += instance.OnSuperAtirar;
                @Rotacionar.started += instance.OnRotacionar;
                @Rotacionar.performed += instance.OnRotacionar;
                @Rotacionar.canceled += instance.OnRotacionar;
                @Mover.started += instance.OnMover;
                @Mover.performed += instance.OnMover;
                @Mover.canceled += instance.OnMover;
            }
        }
    }
    public GameplayActions @gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnAtirar(InputAction.CallbackContext context);
        void OnSuperAtirar(InputAction.CallbackContext context);
        void OnRotacionar(InputAction.CallbackContext context);
        void OnMover(InputAction.CallbackContext context);
    }
}
