using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Input Reader")]
public class InputReader : ScriptableObject, InputActions.IGameplayActions, InputActions.IMenuActions, InputActions.IUniversalActions
{
  // Gameplay Actions
  // Ship
  public event UnityAction IncreaseThrottleEvent = delegate { };
  public event UnityAction DecreaseThrottleEvent = delegate { };
  public event UnityAction RotateLeftEvent = delegate { };
  public event UnityAction RotateRightEvent = delegate { };
  public event UnityAction DockingRequestEvent = delegate { };
  // Camera
  public event UnityAction ZoomInEvent = delegate { };
  public event UnityAction ZoomOutEvent = delegate { };
  public event UnityAction MouseWheelZoomEvent = delegate { };

  // Menu Actions

  // Universal Actions
  public event UnityAction CancelEvent = delegate { };

  // InputActions
  private InputActions inputActions;

  private void OnEnable()
  {
    if (inputActions == null)
    {
      inputActions = new InputActions();
      inputActions.Gameplay.SetCallbacks(this);
      inputActions.Menu.SetCallbacks(this);
      inputActions.Universal.SetCallbacks(this);
    }
  }

  private void OnDisable()
  {
    DisableAllInputs();
  }

  public void EnableGameplayInputs()
  {
    inputActions.Gameplay.Enable();
    inputActions.Universal.Enable();

    inputActions.Menu.Disable();
  }

  public void EnableMenuInputs()
  {
    inputActions.Menu.Enable();
    inputActions.Universal.Enable();

    inputActions.Gameplay.Disable();
  }


  public void DisableAllInputs()
  {
    inputActions.Gameplay.Disable();
    inputActions.Menu.Disable();
    inputActions.Universal.Disable();
  }

  // IGameplayActions

  public void OnIncreaseThrottle(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnDecreaseThrottle(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnRotateLeft(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnRotateRight(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnZoomScroll(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnZoomIn(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnZoomOut(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnFollowSelectedObject(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnOpenRightClickMenu(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnNextOption(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnPreviousOption(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnSelectOption(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }

  public void OnCancel(InputAction.CallbackContext context)
  {
    throw new System.NotImplementedException();
  }
}

