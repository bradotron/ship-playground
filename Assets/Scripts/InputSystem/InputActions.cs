//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/InputSystem/InputActions.inputactions
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

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""d8d06b6b-ea83-4ec4-b71b-b6aee50e2e95"",
            ""actions"": [
                {
                    ""name"": ""IncreaseThrottle"",
                    ""type"": ""Button"",
                    ""id"": ""bb7f8fcf-d8ef-4ea5-8b89-fa093cf18560"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DecreaseThrottle"",
                    ""type"": ""Button"",
                    ""id"": ""83377b80-3180-4f5d-be25-6e5001ce6a39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""cbd2709a-ad33-4c25-966e-83b90f697e66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""cf7fa674-9910-434b-b8df-d67d74ebc709"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ZoomScroll"",
                    ""type"": ""Value"",
                    ""id"": ""ebb1b32b-bab6-4b28-9f4e-ac1642451d60"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ZoomIn"",
                    ""type"": ""Button"",
                    ""id"": ""b7923bcd-fc19-4703-966b-e6cc51e567db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ZoomOut"",
                    ""type"": ""Button"",
                    ""id"": ""f9828ce4-9694-4533-86bd-2df330890278"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FollowSelectedObject"",
                    ""type"": ""Button"",
                    ""id"": ""6c2f6431-d703-4bde-86aa-eabd030fb962"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OpenRightClickMenu"",
                    ""type"": ""Button"",
                    ""id"": ""f5fb4e46-7437-4781-a922-bdc3c4064ecf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""743a54d9-6fd8-474f-841d-b74c1262d9f7"",
                    ""path"": ""W"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncreaseThrottle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8664521-ea3d-4e62-8785-b3f447c38790"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseThrottle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26304b64-f21c-41c1-9ebd-2d9b6d4bfe72"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9832773a-c5db-4536-8219-238f2d83e758"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1d0492a-e2e2-4965-bee6-c9a7fc8c900b"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dfd489e-87bb-45a0-ab19-b4aa9ea7c43b"",
                    ""path"": ""<Keyboard>/equals"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed7170a7-2bdc-49e7-8296-fba2212303ef"",
                    ""path"": ""<Keyboard>/minus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cf852da-ddd6-416a-aa86-1febd2aa9481"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FollowSelectedObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a6ac5df-a9ed-4d75-b865-a190af0762d8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenRightClickMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""449e966b-dfaa-4a18-a9bd-7bf4484f2368"",
            ""actions"": [
                {
                    ""name"": ""NextOption"",
                    ""type"": ""Button"",
                    ""id"": ""5f67075f-6dfe-4b25-a10b-2db937a92046"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PreviousOption"",
                    ""type"": ""Button"",
                    ""id"": ""84e3c6ef-22b1-4599-8b7f-75d538b0080f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectOption"",
                    ""type"": ""Button"",
                    ""id"": ""f22305ce-f9a7-4508-9841-07b28392ac04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2b66383f-e078-4052-9bb5-4eef583c6aef"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextOption"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c68ba10-2912-44ca-b786-b67297d09048"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextOption"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eae2a2c9-fcfc-4450-a397-ce119695deac"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousOption"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6a90923-c40b-448f-b0ba-467df3df48e6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousOption"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f2bb05a-d56e-4b08-8944-a155469f6f4d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectOption"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31a9a77d-d973-40d4-962d-fb8024bf7cf6"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectOption"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Universal"",
            ""id"": ""3d9445c4-3adf-4570-932c-7f25bf161fde"",
            ""actions"": [
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""a8ab5104-b417-42bc-92c5-c373008faf8f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c3bedf65-ac80-4332-a5b5-d565e1df2dea"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb97bf61-34fa-438d-8c3e-808278e98b7e"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_IncreaseThrottle = m_Gameplay.FindAction("IncreaseThrottle", throwIfNotFound: true);
        m_Gameplay_DecreaseThrottle = m_Gameplay.FindAction("DecreaseThrottle", throwIfNotFound: true);
        m_Gameplay_RotateLeft = m_Gameplay.FindAction("RotateLeft", throwIfNotFound: true);
        m_Gameplay_RotateRight = m_Gameplay.FindAction("RotateRight", throwIfNotFound: true);
        m_Gameplay_ZoomScroll = m_Gameplay.FindAction("ZoomScroll", throwIfNotFound: true);
        m_Gameplay_ZoomIn = m_Gameplay.FindAction("ZoomIn", throwIfNotFound: true);
        m_Gameplay_ZoomOut = m_Gameplay.FindAction("ZoomOut", throwIfNotFound: true);
        m_Gameplay_FollowSelectedObject = m_Gameplay.FindAction("FollowSelectedObject", throwIfNotFound: true);
        m_Gameplay_OpenRightClickMenu = m_Gameplay.FindAction("OpenRightClickMenu", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_NextOption = m_Menu.FindAction("NextOption", throwIfNotFound: true);
        m_Menu_PreviousOption = m_Menu.FindAction("PreviousOption", throwIfNotFound: true);
        m_Menu_SelectOption = m_Menu.FindAction("SelectOption", throwIfNotFound: true);
        // Universal
        m_Universal = asset.FindActionMap("Universal", throwIfNotFound: true);
        m_Universal_Cancel = m_Universal.FindAction("Cancel", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_IncreaseThrottle;
    private readonly InputAction m_Gameplay_DecreaseThrottle;
    private readonly InputAction m_Gameplay_RotateLeft;
    private readonly InputAction m_Gameplay_RotateRight;
    private readonly InputAction m_Gameplay_ZoomScroll;
    private readonly InputAction m_Gameplay_ZoomIn;
    private readonly InputAction m_Gameplay_ZoomOut;
    private readonly InputAction m_Gameplay_FollowSelectedObject;
    private readonly InputAction m_Gameplay_OpenRightClickMenu;
    public struct GameplayActions
    {
        private @InputActions m_Wrapper;
        public GameplayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @IncreaseThrottle => m_Wrapper.m_Gameplay_IncreaseThrottle;
        public InputAction @DecreaseThrottle => m_Wrapper.m_Gameplay_DecreaseThrottle;
        public InputAction @RotateLeft => m_Wrapper.m_Gameplay_RotateLeft;
        public InputAction @RotateRight => m_Wrapper.m_Gameplay_RotateRight;
        public InputAction @ZoomScroll => m_Wrapper.m_Gameplay_ZoomScroll;
        public InputAction @ZoomIn => m_Wrapper.m_Gameplay_ZoomIn;
        public InputAction @ZoomOut => m_Wrapper.m_Gameplay_ZoomOut;
        public InputAction @FollowSelectedObject => m_Wrapper.m_Gameplay_FollowSelectedObject;
        public InputAction @OpenRightClickMenu => m_Wrapper.m_Gameplay_OpenRightClickMenu;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @IncreaseThrottle.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIncreaseThrottle;
                @IncreaseThrottle.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIncreaseThrottle;
                @IncreaseThrottle.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIncreaseThrottle;
                @DecreaseThrottle.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDecreaseThrottle;
                @DecreaseThrottle.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDecreaseThrottle;
                @DecreaseThrottle.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDecreaseThrottle;
                @RotateLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateLeft;
                @RotateRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateRight;
                @ZoomScroll.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomScroll;
                @ZoomScroll.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomScroll;
                @ZoomScroll.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomScroll;
                @ZoomIn.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomIn;
                @ZoomIn.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomIn;
                @ZoomIn.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomIn;
                @ZoomOut.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomOut;
                @ZoomOut.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomOut;
                @ZoomOut.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZoomOut;
                @FollowSelectedObject.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFollowSelectedObject;
                @FollowSelectedObject.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFollowSelectedObject;
                @FollowSelectedObject.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFollowSelectedObject;
                @OpenRightClickMenu.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenRightClickMenu;
                @OpenRightClickMenu.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenRightClickMenu;
                @OpenRightClickMenu.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenRightClickMenu;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @IncreaseThrottle.started += instance.OnIncreaseThrottle;
                @IncreaseThrottle.performed += instance.OnIncreaseThrottle;
                @IncreaseThrottle.canceled += instance.OnIncreaseThrottle;
                @DecreaseThrottle.started += instance.OnDecreaseThrottle;
                @DecreaseThrottle.performed += instance.OnDecreaseThrottle;
                @DecreaseThrottle.canceled += instance.OnDecreaseThrottle;
                @RotateLeft.started += instance.OnRotateLeft;
                @RotateLeft.performed += instance.OnRotateLeft;
                @RotateLeft.canceled += instance.OnRotateLeft;
                @RotateRight.started += instance.OnRotateRight;
                @RotateRight.performed += instance.OnRotateRight;
                @RotateRight.canceled += instance.OnRotateRight;
                @ZoomScroll.started += instance.OnZoomScroll;
                @ZoomScroll.performed += instance.OnZoomScroll;
                @ZoomScroll.canceled += instance.OnZoomScroll;
                @ZoomIn.started += instance.OnZoomIn;
                @ZoomIn.performed += instance.OnZoomIn;
                @ZoomIn.canceled += instance.OnZoomIn;
                @ZoomOut.started += instance.OnZoomOut;
                @ZoomOut.performed += instance.OnZoomOut;
                @ZoomOut.canceled += instance.OnZoomOut;
                @FollowSelectedObject.started += instance.OnFollowSelectedObject;
                @FollowSelectedObject.performed += instance.OnFollowSelectedObject;
                @FollowSelectedObject.canceled += instance.OnFollowSelectedObject;
                @OpenRightClickMenu.started += instance.OnOpenRightClickMenu;
                @OpenRightClickMenu.performed += instance.OnOpenRightClickMenu;
                @OpenRightClickMenu.canceled += instance.OnOpenRightClickMenu;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_NextOption;
    private readonly InputAction m_Menu_PreviousOption;
    private readonly InputAction m_Menu_SelectOption;
    public struct MenuActions
    {
        private @InputActions m_Wrapper;
        public MenuActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextOption => m_Wrapper.m_Menu_NextOption;
        public InputAction @PreviousOption => m_Wrapper.m_Menu_PreviousOption;
        public InputAction @SelectOption => m_Wrapper.m_Menu_SelectOption;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @NextOption.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNextOption;
                @NextOption.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNextOption;
                @NextOption.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNextOption;
                @PreviousOption.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPreviousOption;
                @PreviousOption.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPreviousOption;
                @PreviousOption.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPreviousOption;
                @SelectOption.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectOption;
                @SelectOption.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectOption;
                @SelectOption.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectOption;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NextOption.started += instance.OnNextOption;
                @NextOption.performed += instance.OnNextOption;
                @NextOption.canceled += instance.OnNextOption;
                @PreviousOption.started += instance.OnPreviousOption;
                @PreviousOption.performed += instance.OnPreviousOption;
                @PreviousOption.canceled += instance.OnPreviousOption;
                @SelectOption.started += instance.OnSelectOption;
                @SelectOption.performed += instance.OnSelectOption;
                @SelectOption.canceled += instance.OnSelectOption;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Universal
    private readonly InputActionMap m_Universal;
    private IUniversalActions m_UniversalActionsCallbackInterface;
    private readonly InputAction m_Universal_Cancel;
    public struct UniversalActions
    {
        private @InputActions m_Wrapper;
        public UniversalActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Cancel => m_Wrapper.m_Universal_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_Universal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UniversalActions set) { return set.Get(); }
        public void SetCallbacks(IUniversalActions instance)
        {
            if (m_Wrapper.m_UniversalActionsCallbackInterface != null)
            {
                @Cancel.started -= m_Wrapper.m_UniversalActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UniversalActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UniversalActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_UniversalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public UniversalActions @Universal => new UniversalActions(this);
    public interface IGameplayActions
    {
        void OnIncreaseThrottle(InputAction.CallbackContext context);
        void OnDecreaseThrottle(InputAction.CallbackContext context);
        void OnRotateLeft(InputAction.CallbackContext context);
        void OnRotateRight(InputAction.CallbackContext context);
        void OnZoomScroll(InputAction.CallbackContext context);
        void OnZoomIn(InputAction.CallbackContext context);
        void OnZoomOut(InputAction.CallbackContext context);
        void OnFollowSelectedObject(InputAction.CallbackContext context);
        void OnOpenRightClickMenu(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnNextOption(InputAction.CallbackContext context);
        void OnPreviousOption(InputAction.CallbackContext context);
        void OnSelectOption(InputAction.CallbackContext context);
    }
    public interface IUniversalActions
    {
        void OnCancel(InputAction.CallbackContext context);
    }
}
