// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""852c285e-e8ba-4299-ae31-2621cbbde9da"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""3eced7a7-5128-4f55-992f-e5d43c14dfdb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BodyShapeAddition"",
                    ""type"": ""Value"",
                    ""id"": ""b661f69a-246e-469a-99de-5b64703901b3"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BlendShapeSwitch"",
                    ""type"": ""Value"",
                    ""id"": ""fb9aec98-0452-4f8a-8592-fb179591701f"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMove"",
                    ""type"": ""Value"",
                    ""id"": ""1eb27ecf-7dd5-401d-9f16-23ab9059f1b2"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraZoomOut"",
                    ""type"": ""Button"",
                    ""id"": ""2b156e38-8153-472d-ae16-5a28026b79fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraZoomIn"",
                    ""type"": ""Button"",
                    ""id"": ""40112817-57b8-40e8-a787-dd8a9d517e50"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MaleSpawn"",
                    ""type"": ""Value"",
                    ""id"": ""23b74543-365c-4f95-939e-88dfd7c21f66"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FemaleSpawn"",
                    ""type"": ""Value"",
                    ""id"": ""25e7180e-7376-4d43-91bb-3eff118c5cfd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ReturnToMenu"",
                    ""type"": ""Button"",
                    ""id"": ""c1812e25-9511-4bb1-b4f8-2e3cc1981935"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnimationOne"",
                    ""type"": ""Value"",
                    ""id"": ""2b97609b-1271-405e-8c90-d92290a85891"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnimationTwo"",
                    ""type"": ""Value"",
                    ""id"": ""baa05fb0-6d82-425b-a78c-57dafae5907f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MaleListControl"",
                    ""type"": ""Button"",
                    ""id"": ""e3b8a7ac-7da5-4dc6-9aa0-f7cf6258a374"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FemaleListControl"",
                    ""type"": ""Button"",
                    ""id"": ""0a5f5c40-f9ad-4601-bab3-4c01d96d44c0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Index"",
                    ""id"": ""bd8791c9-71ca-4a4d-92c5-899bb7aab2c6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BlendShapeSwitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cfc2dfe8-e4c1-4d07-af76-82d0a7385767"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BlendShapeSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a7ee139e-c139-4ff9-b88d-ffa43ad9b5d6"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BlendShapeSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e0f1beca-78d0-414a-8a98-281d1e0305ab"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a1def37-806b-4809-b4c6-5dbf3ef092dd"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraZoomOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7318d6de-c55c-41fb-ac00-1e6e345bb011"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraZoomIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b12925d3-6309-4dee-94e0-52e94ed15747"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14dddfd1-a066-4f9e-abea-0e0cb33e6e4a"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b1a6c463-f006-4529-8ab9-17ddd927a8ee"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fe2f87d2-20b5-42c2-ad51-967b9e081e99"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c576609b-04ef-47a3-b07a-b8fa90eb17cc"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Value"",
                    ""id"": ""4d2a3691-46bb-440f-8568-0e9a845eab6b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BodyShapeAddition"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e3f3d599-c474-45cb-9712-e8c5ffc761e3"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BodyShapeAddition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""29a5c63a-fed2-478e-bfc8-d548f99a181e"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BodyShapeAddition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fc588f95-3e46-4d64-add1-e351fd55d814"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MaleSpawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f332dac4-a294-41b4-8b83-95a4fa044600"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FemaleSpawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0abb5a8e-811d-462e-b19f-f4c5075ae10b"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReturnToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4dc44691-a9b9-4e09-8239-609053b40319"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnimationOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de06e746-41d6-45be-8b37-41acb762f864"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnimationTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7c3f14b-d168-4280-a3e2-35f78bb145e3"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MaleListControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4754f62-bf52-41d8-977f-528f6df8f802"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FemaleListControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Movement = m_GamePlay.FindAction("Movement", throwIfNotFound: true);
        m_GamePlay_BodyShapeAddition = m_GamePlay.FindAction("BodyShapeAddition", throwIfNotFound: true);
        m_GamePlay_BlendShapeSwitch = m_GamePlay.FindAction("BlendShapeSwitch", throwIfNotFound: true);
        m_GamePlay_CameraMove = m_GamePlay.FindAction("CameraMove", throwIfNotFound: true);
        m_GamePlay_CameraZoomOut = m_GamePlay.FindAction("CameraZoomOut", throwIfNotFound: true);
        m_GamePlay_CameraZoomIn = m_GamePlay.FindAction("CameraZoomIn", throwIfNotFound: true);
        m_GamePlay_MaleSpawn = m_GamePlay.FindAction("MaleSpawn", throwIfNotFound: true);
        m_GamePlay_FemaleSpawn = m_GamePlay.FindAction("FemaleSpawn", throwIfNotFound: true);
        m_GamePlay_ReturnToMenu = m_GamePlay.FindAction("ReturnToMenu", throwIfNotFound: true);
        m_GamePlay_AnimationOne = m_GamePlay.FindAction("AnimationOne", throwIfNotFound: true);
        m_GamePlay_AnimationTwo = m_GamePlay.FindAction("AnimationTwo", throwIfNotFound: true);
        m_GamePlay_MaleListControl = m_GamePlay.FindAction("MaleListControl", throwIfNotFound: true);
        m_GamePlay_FemaleListControl = m_GamePlay.FindAction("FemaleListControl", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Movement;
    private readonly InputAction m_GamePlay_BodyShapeAddition;
    private readonly InputAction m_GamePlay_BlendShapeSwitch;
    private readonly InputAction m_GamePlay_CameraMove;
    private readonly InputAction m_GamePlay_CameraZoomOut;
    private readonly InputAction m_GamePlay_CameraZoomIn;
    private readonly InputAction m_GamePlay_MaleSpawn;
    private readonly InputAction m_GamePlay_FemaleSpawn;
    private readonly InputAction m_GamePlay_ReturnToMenu;
    private readonly InputAction m_GamePlay_AnimationOne;
    private readonly InputAction m_GamePlay_AnimationTwo;
    private readonly InputAction m_GamePlay_MaleListControl;
    private readonly InputAction m_GamePlay_FemaleListControl;
    public struct GamePlayActions
    {
        private @PlayerControls m_Wrapper;
        public GamePlayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GamePlay_Movement;
        public InputAction @BodyShapeAddition => m_Wrapper.m_GamePlay_BodyShapeAddition;
        public InputAction @BlendShapeSwitch => m_Wrapper.m_GamePlay_BlendShapeSwitch;
        public InputAction @CameraMove => m_Wrapper.m_GamePlay_CameraMove;
        public InputAction @CameraZoomOut => m_Wrapper.m_GamePlay_CameraZoomOut;
        public InputAction @CameraZoomIn => m_Wrapper.m_GamePlay_CameraZoomIn;
        public InputAction @MaleSpawn => m_Wrapper.m_GamePlay_MaleSpawn;
        public InputAction @FemaleSpawn => m_Wrapper.m_GamePlay_FemaleSpawn;
        public InputAction @ReturnToMenu => m_Wrapper.m_GamePlay_ReturnToMenu;
        public InputAction @AnimationOne => m_Wrapper.m_GamePlay_AnimationOne;
        public InputAction @AnimationTwo => m_Wrapper.m_GamePlay_AnimationTwo;
        public InputAction @MaleListControl => m_Wrapper.m_GamePlay_MaleListControl;
        public InputAction @FemaleListControl => m_Wrapper.m_GamePlay_FemaleListControl;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                @BodyShapeAddition.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBodyShapeAddition;
                @BodyShapeAddition.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBodyShapeAddition;
                @BodyShapeAddition.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBodyShapeAddition;
                @BlendShapeSwitch.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBlendShapeSwitch;
                @BlendShapeSwitch.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBlendShapeSwitch;
                @BlendShapeSwitch.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBlendShapeSwitch;
                @CameraMove.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraMove;
                @CameraMove.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraMove;
                @CameraMove.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraMove;
                @CameraZoomOut.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraZoomOut;
                @CameraZoomOut.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraZoomOut;
                @CameraZoomOut.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraZoomOut;
                @CameraZoomIn.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraZoomIn;
                @CameraZoomIn.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraZoomIn;
                @CameraZoomIn.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCameraZoomIn;
                @MaleSpawn.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMaleSpawn;
                @MaleSpawn.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMaleSpawn;
                @MaleSpawn.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMaleSpawn;
                @FemaleSpawn.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFemaleSpawn;
                @FemaleSpawn.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFemaleSpawn;
                @FemaleSpawn.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFemaleSpawn;
                @ReturnToMenu.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnReturnToMenu;
                @ReturnToMenu.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnReturnToMenu;
                @ReturnToMenu.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnReturnToMenu;
                @AnimationOne.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAnimationOne;
                @AnimationOne.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAnimationOne;
                @AnimationOne.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAnimationOne;
                @AnimationTwo.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAnimationTwo;
                @AnimationTwo.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAnimationTwo;
                @AnimationTwo.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAnimationTwo;
                @MaleListControl.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMaleListControl;
                @MaleListControl.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMaleListControl;
                @MaleListControl.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMaleListControl;
                @FemaleListControl.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFemaleListControl;
                @FemaleListControl.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFemaleListControl;
                @FemaleListControl.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFemaleListControl;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @BodyShapeAddition.started += instance.OnBodyShapeAddition;
                @BodyShapeAddition.performed += instance.OnBodyShapeAddition;
                @BodyShapeAddition.canceled += instance.OnBodyShapeAddition;
                @BlendShapeSwitch.started += instance.OnBlendShapeSwitch;
                @BlendShapeSwitch.performed += instance.OnBlendShapeSwitch;
                @BlendShapeSwitch.canceled += instance.OnBlendShapeSwitch;
                @CameraMove.started += instance.OnCameraMove;
                @CameraMove.performed += instance.OnCameraMove;
                @CameraMove.canceled += instance.OnCameraMove;
                @CameraZoomOut.started += instance.OnCameraZoomOut;
                @CameraZoomOut.performed += instance.OnCameraZoomOut;
                @CameraZoomOut.canceled += instance.OnCameraZoomOut;
                @CameraZoomIn.started += instance.OnCameraZoomIn;
                @CameraZoomIn.performed += instance.OnCameraZoomIn;
                @CameraZoomIn.canceled += instance.OnCameraZoomIn;
                @MaleSpawn.started += instance.OnMaleSpawn;
                @MaleSpawn.performed += instance.OnMaleSpawn;
                @MaleSpawn.canceled += instance.OnMaleSpawn;
                @FemaleSpawn.started += instance.OnFemaleSpawn;
                @FemaleSpawn.performed += instance.OnFemaleSpawn;
                @FemaleSpawn.canceled += instance.OnFemaleSpawn;
                @ReturnToMenu.started += instance.OnReturnToMenu;
                @ReturnToMenu.performed += instance.OnReturnToMenu;
                @ReturnToMenu.canceled += instance.OnReturnToMenu;
                @AnimationOne.started += instance.OnAnimationOne;
                @AnimationOne.performed += instance.OnAnimationOne;
                @AnimationOne.canceled += instance.OnAnimationOne;
                @AnimationTwo.started += instance.OnAnimationTwo;
                @AnimationTwo.performed += instance.OnAnimationTwo;
                @AnimationTwo.canceled += instance.OnAnimationTwo;
                @MaleListControl.started += instance.OnMaleListControl;
                @MaleListControl.performed += instance.OnMaleListControl;
                @MaleListControl.canceled += instance.OnMaleListControl;
                @FemaleListControl.started += instance.OnFemaleListControl;
                @FemaleListControl.performed += instance.OnFemaleListControl;
                @FemaleListControl.canceled += instance.OnFemaleListControl;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    public interface IGamePlayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnBodyShapeAddition(InputAction.CallbackContext context);
        void OnBlendShapeSwitch(InputAction.CallbackContext context);
        void OnCameraMove(InputAction.CallbackContext context);
        void OnCameraZoomOut(InputAction.CallbackContext context);
        void OnCameraZoomIn(InputAction.CallbackContext context);
        void OnMaleSpawn(InputAction.CallbackContext context);
        void OnFemaleSpawn(InputAction.CallbackContext context);
        void OnReturnToMenu(InputAction.CallbackContext context);
        void OnAnimationOne(InputAction.CallbackContext context);
        void OnAnimationTwo(InputAction.CallbackContext context);
        void OnMaleListControl(InputAction.CallbackContext context);
        void OnFemaleListControl(InputAction.CallbackContext context);
    }
}
