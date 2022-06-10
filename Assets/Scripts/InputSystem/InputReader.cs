using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Input Reader")]
public class InputReader : ScriptableObject, InputActions.IGameplayActions, InputActions.IMenuActions, InputActions.IUniversalActions
{
  // Gameplay Events
  // Ship
  public event UnityAction IncreaseThrottleStartEvent = delegate { };
  public event UnityAction IncreaseThrottleStopEvent = delegate { };
  public event UnityAction DecreaseThrottleStartEvent = delegate { };
  public event UnityAction DecreaseThrottleStopEvent = delegate { };
  public event UnityAction RotateLeftStartEvent = delegate { };
  public event UnityAction RotateLeftStopEvent = delegate { };
  public event UnityAction RotateRightStartEvent = delegate { };
  public event UnityAction RotateRightStopEvent = delegate { };
  public event UnityAction DockingRequestEvent = delegate { };
  
  // Camera
  public event UnityAction ZoomInStartEvent = delegate { };
  public event UnityAction ZoomInStopEvent = delegate { };
  public event UnityAction ZoomOutStartEvent = delegate { };
  public event UnityAction ZoomOutStopEvent = delegate { };
  public event UnityAction<float> MouseWheelZoomEvent = delegate { };

  // Menu Events

  // Universal Events
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
    switch (context.phase)
    {
      case InputActionPhase.Started:
        IncreaseThrottleStartEvent.Invoke();
        break;
      case InputActionPhase.Canceled:
        IncreaseThrottleStopEvent.Invoke();
        break;
      default:
        break;
    }
  }

  public void OnDecreaseThrottle(InputAction.CallbackContext context)
  {
    switch (context.phase)
    {
      case InputActionPhase.Started:
        DecreaseThrottleStartEvent.Invoke();
        break;
      case InputActionPhase.Canceled:
        DecreaseThrottleStopEvent.Invoke();
        break;
      default:
        break;
    }
  }

  public void OnRotateLeft(InputAction.CallbackContext context)
  {
    switch (context.phase)
    {
      case InputActionPhase.Started:
        RotateLeftStartEvent.Invoke();
        break;
      case InputActionPhase.Canceled:
        RotateLeftStopEvent.Invoke();
        break;
      default:
        break;
    }
  }

  public void OnRotateRight(InputAction.CallbackContext context)
  {
    switch (context.phase)
    {
      case InputActionPhase.Started:
        RotateRightStartEvent.Invoke();
        break;
      case InputActionPhase.Canceled:
        RotateRightStopEvent.Invoke();
        break;
      default:
        break;
    }
  }

  public void OnZoomScroll(InputAction.CallbackContext context)
  {
    if (context.phase == InputActionPhase.Performed)
    {
      MouseWheelZoomEvent.Invoke(context.ReadValue<Vector2>().normalized.y);
    }
  }

  public void OnZoomIn(InputAction.CallbackContext context)
  {
    switch (context.phase)
    {
      case InputActionPhase.Started:
        ZoomInStartEvent.Invoke();
        break;
      case InputActionPhase.Canceled:
        ZoomInStopEvent.Invoke();
        break;
      default:
        break;
    }
  }

  public void OnZoomOut(InputAction.CallbackContext context)
  {
    switch (context.phase)
    {
      case InputActionPhase.Started:
        ZoomOutStartEvent.Invoke();
        break;
      case InputActionPhase.Canceled:
        ZoomOutStopEvent.Invoke();
        break;
      default:
        break;
    }
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
    if (context.phase == InputActionPhase.Started)
    {
      CancelEvent.Invoke();
    }
  }
}

