//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.1
//     from Assets/UnityModules/NewInputSystem/Assets/InputSystem/TouchInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @TouchInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchInput"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""e910ef71-9161-47f1-a5c7-7c3a78343a70"",
            ""actions"": [
                {
                    ""name"": ""OneTapIgnoredDoubleTap"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3a588ada-f65c-4753-8862-535be13dcacf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DoubleTap"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3dcf88f5-9952-4c7c-891a-079ddba81575"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap,Tap"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DragTouch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ca287ea2-aa4c-4da7-8cf2-78f40acf23e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrimaryTouchPosition"",
                    ""type"": ""Value"",
                    ""id"": ""8481539c-817c-48bc-a335-230349b9adba"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryTouchPosition"",
                    ""type"": ""Value"",
                    ""id"": ""2d01da8c-d532-466c-b06e-01dddcd6d29d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryTouchContact"",
                    ""type"": ""Button"",
                    ""id"": ""3b87da02-e4c4-42b6-a3a0-e1f0182b4068"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ZoomUpButton"",
                    ""type"": ""Button"",
                    ""id"": ""6da00744-0e3d-4301-aa33-49b4e4ee77eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ZoomDownButton"",
                    ""type"": ""Button"",
                    ""id"": ""0399359c-b2ec-49e6-98c1-d6853a3cc6ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WheelZoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3ab92271-89b7-4a9f-9e4b-f7e0ee769916"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""42fc77b1-15a2-452b-acd6-6ed7ca5292bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b522b66c-8f75-4cf5-98d5-76e13084a38e"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""DoubleTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cea0ba0f-31d8-441c-a38e-f783c40a816e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""DoubleTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34d509c7-546d-4302-9991-4c3c0e2a958e"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""PrimaryTouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1392970f-acd6-4005-b78b-6fe43531928b"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""PrimaryTouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10373b95-7035-4229-b887-9701a33dfdd1"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""SecondaryTouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7abfee60-8708-401d-8c7e-a39c68ad1c28"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""SecondaryTouchContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc187476-69c3-4755-81cb-d36c75b44f7e"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""WheelZoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""334071e1-30d6-44eb-b2c1-b62bc970c36e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""309de6b6-d1d9-4104-8cb7-0a26fdbf0b7e"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""OneTapIgnoredDoubleTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d8354df-d3f7-4969-abaa-f1b441e8caff"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""OneTapIgnoredDoubleTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3c9dc4e-c626-41c3-971a-c619e64e80d5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": ""Hold,Tap"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""ZoomUpButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4834fb9d-0d62-488f-b21a-34c018ab8170"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": ""Hold,Tap"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""ZoomDownButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97a3ef10-2f16-4821-979c-ddd6eaa24274"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""DragTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa3f16cb-c41a-4c84-b75b-18937140b110"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DragTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""2a8dd2b0-8af4-4fbb-a33f-ec9666ccfadb"",
            ""actions"": [
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3f8383c1-f85c-4f4d-b404-3d6ca864392b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8b24ab76-f3f0-4fe3-8862-cb8e92c78752"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b7121c95-950f-4d48-a8d4-0cae1f566751"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""Button"",
                    ""id"": ""9664d5ca-3b62-4f39-88db-56d6bb5b9ec3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""fea4d8cd-54ff-48a4-b0b9-168a687066fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""890bc99b-4985-4280-8b1d-77b66e811c33"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f13b1acd-9c5e-456d-bb4d-2ed94be52cb3"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa38f86e-40b0-4bfc-b117-f6ec373df93a"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e50f4f4d-0eee-4442-bf99-97c29062968d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ccfeba63-3321-43aa-a504-0d526da3e0f9"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6718e011-fa17-43b1-9fc5-3cbc1671ad3e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39604b1b-2f68-40ba-bc87-ce05adf9af03"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyBoard&Mouse"",
            ""bindingGroup"": ""KeyBoard&Mouse"",
            ""devices"": []
        }
    ]
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_OneTapIgnoredDoubleTap = m_Touch.FindAction("OneTapIgnoredDoubleTap", throwIfNotFound: true);
        m_Touch_DoubleTap = m_Touch.FindAction("DoubleTap", throwIfNotFound: true);
        m_Touch_DragTouch = m_Touch.FindAction("DragTouch", throwIfNotFound: true);
        m_Touch_PrimaryTouchPosition = m_Touch.FindAction("PrimaryTouchPosition", throwIfNotFound: true);
        m_Touch_SecondaryTouchPosition = m_Touch.FindAction("SecondaryTouchPosition", throwIfNotFound: true);
        m_Touch_SecondaryTouchContact = m_Touch.FindAction("SecondaryTouchContact", throwIfNotFound: true);
        m_Touch_ZoomUpButton = m_Touch.FindAction("ZoomUpButton", throwIfNotFound: true);
        m_Touch_ZoomDownButton = m_Touch.FindAction("ZoomDownButton", throwIfNotFound: true);
        m_Touch_WheelZoom = m_Touch.FindAction("WheelZoom", throwIfNotFound: true);
        m_Touch_MiddleClick = m_Touch.FindAction("MiddleClick", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_OneTapIgnoredDoubleTap;
    private readonly InputAction m_Touch_DoubleTap;
    private readonly InputAction m_Touch_DragTouch;
    private readonly InputAction m_Touch_PrimaryTouchPosition;
    private readonly InputAction m_Touch_SecondaryTouchPosition;
    private readonly InputAction m_Touch_SecondaryTouchContact;
    private readonly InputAction m_Touch_ZoomUpButton;
    private readonly InputAction m_Touch_ZoomDownButton;
    private readonly InputAction m_Touch_WheelZoom;
    private readonly InputAction m_Touch_MiddleClick;
    public struct TouchActions
    {
        private @TouchInput m_Wrapper;
        public TouchActions(@TouchInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @OneTapIgnoredDoubleTap => m_Wrapper.m_Touch_OneTapIgnoredDoubleTap;
        public InputAction @DoubleTap => m_Wrapper.m_Touch_DoubleTap;
        public InputAction @DragTouch => m_Wrapper.m_Touch_DragTouch;
        public InputAction @PrimaryTouchPosition => m_Wrapper.m_Touch_PrimaryTouchPosition;
        public InputAction @SecondaryTouchPosition => m_Wrapper.m_Touch_SecondaryTouchPosition;
        public InputAction @SecondaryTouchContact => m_Wrapper.m_Touch_SecondaryTouchContact;
        public InputAction @ZoomUpButton => m_Wrapper.m_Touch_ZoomUpButton;
        public InputAction @ZoomDownButton => m_Wrapper.m_Touch_ZoomDownButton;
        public InputAction @WheelZoom => m_Wrapper.m_Touch_WheelZoom;
        public InputAction @MiddleClick => m_Wrapper.m_Touch_MiddleClick;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @OneTapIgnoredDoubleTap.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnOneTapIgnoredDoubleTap;
                @OneTapIgnoredDoubleTap.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnOneTapIgnoredDoubleTap;
                @OneTapIgnoredDoubleTap.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnOneTapIgnoredDoubleTap;
                @DoubleTap.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnDoubleTap;
                @DoubleTap.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnDoubleTap;
                @DoubleTap.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnDoubleTap;
                @DragTouch.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnDragTouch;
                @DragTouch.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnDragTouch;
                @DragTouch.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnDragTouch;
                @PrimaryTouchPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryTouchPosition;
                @PrimaryTouchPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryTouchPosition;
                @PrimaryTouchPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryTouchPosition;
                @SecondaryTouchPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchPosition;
                @SecondaryTouchPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchPosition;
                @SecondaryTouchPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchPosition;
                @SecondaryTouchContact.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @SecondaryTouchContact.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @SecondaryTouchContact.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @ZoomUpButton.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnZoomUpButton;
                @ZoomUpButton.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnZoomUpButton;
                @ZoomUpButton.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnZoomUpButton;
                @ZoomDownButton.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnZoomDownButton;
                @ZoomDownButton.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnZoomDownButton;
                @ZoomDownButton.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnZoomDownButton;
                @WheelZoom.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnWheelZoom;
                @WheelZoom.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnWheelZoom;
                @WheelZoom.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnWheelZoom;
                @MiddleClick.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnMiddleClick;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OneTapIgnoredDoubleTap.started += instance.OnOneTapIgnoredDoubleTap;
                @OneTapIgnoredDoubleTap.performed += instance.OnOneTapIgnoredDoubleTap;
                @OneTapIgnoredDoubleTap.canceled += instance.OnOneTapIgnoredDoubleTap;
                @DoubleTap.started += instance.OnDoubleTap;
                @DoubleTap.performed += instance.OnDoubleTap;
                @DoubleTap.canceled += instance.OnDoubleTap;
                @DragTouch.started += instance.OnDragTouch;
                @DragTouch.performed += instance.OnDragTouch;
                @DragTouch.canceled += instance.OnDragTouch;
                @PrimaryTouchPosition.started += instance.OnPrimaryTouchPosition;
                @PrimaryTouchPosition.performed += instance.OnPrimaryTouchPosition;
                @PrimaryTouchPosition.canceled += instance.OnPrimaryTouchPosition;
                @SecondaryTouchPosition.started += instance.OnSecondaryTouchPosition;
                @SecondaryTouchPosition.performed += instance.OnSecondaryTouchPosition;
                @SecondaryTouchPosition.canceled += instance.OnSecondaryTouchPosition;
                @SecondaryTouchContact.started += instance.OnSecondaryTouchContact;
                @SecondaryTouchContact.performed += instance.OnSecondaryTouchContact;
                @SecondaryTouchContact.canceled += instance.OnSecondaryTouchContact;
                @ZoomUpButton.started += instance.OnZoomUpButton;
                @ZoomUpButton.performed += instance.OnZoomUpButton;
                @ZoomUpButton.canceled += instance.OnZoomUpButton;
                @ZoomDownButton.started += instance.OnZoomDownButton;
                @ZoomDownButton.performed += instance.OnZoomDownButton;
                @ZoomDownButton.canceled += instance.OnZoomDownButton;
                @WheelZoom.started += instance.OnWheelZoom;
                @WheelZoom.performed += instance.OnWheelZoom;
                @WheelZoom.canceled += instance.OnWheelZoom;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_ScrollWheel;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_RightClick;
    public struct UIActions
    {
        private @TouchInput m_Wrapper;
        public UIActions(@TouchInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_KeyBoardMouseSchemeIndex = -1;
    public InputControlScheme KeyBoardMouseScheme
    {
        get
        {
            if (m_KeyBoardMouseSchemeIndex == -1) m_KeyBoardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyBoard&Mouse");
            return asset.controlSchemes[m_KeyBoardMouseSchemeIndex];
        }
    }
    public interface ITouchActions
    {
        void OnOneTapIgnoredDoubleTap(InputAction.CallbackContext context);
        void OnDoubleTap(InputAction.CallbackContext context);
        void OnDragTouch(InputAction.CallbackContext context);
        void OnPrimaryTouchPosition(InputAction.CallbackContext context);
        void OnSecondaryTouchPosition(InputAction.CallbackContext context);
        void OnSecondaryTouchContact(InputAction.CallbackContext context);
        void OnZoomUpButton(InputAction.CallbackContext context);
        void OnZoomDownButton(InputAction.CallbackContext context);
        void OnWheelZoom(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
    }
}
