using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mouse2D : MonoBehaviour
{
  public UnityEvent RightClickDown;
  public UnityEvent RightClickHeld;
  public UnityEvent RightClickUp;
  public UnityEvent LeftClickDown;
  public UnityEvent LeftClickHeld;
  public UnityEvent LeftClickUp;
  public UnityEvent MouseWheelForward;
  public UnityEvent MouseWheelBackward;

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      LeftClickDown?.Invoke();
    }

    if (Input.GetMouseButton(0))
    {
      LeftClickHeld?.Invoke();
    }

    if (Input.GetMouseButtonUp(0))
    {
      LeftClickUp?.Invoke();
    }

    if (Input.GetMouseButtonDown(1))
    {
      RightClickDown?.Invoke();
    }

    if (Input.GetMouseButton(1))
    {
      RightClickHeld?.Invoke();
    }

    if (Input.GetMouseButtonUp(1))
    {
      RightClickUp?.Invoke();
    }

    if (Input.mouseScrollDelta.y > 0)
    {
      MouseWheelForward?.Invoke();
    }
    
    if (Input.mouseScrollDelta.y < 0)
    {
      MouseWheelBackward?.Invoke();
    }
  }
}
