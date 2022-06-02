using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputEvents : MonoBehaviour
{
  public KeyCodeEvents IncreaseThrottle;
  public KeyCodeEvents DecreaseThrottle;
  public KeyCodeEvents RotateDesiredHeadingLeft;
  public KeyCodeEvents RotateDesiredHeadingRight;
  private List<KeyCodeEvents> InputBindings;


  private void Awake()
  {
    InputBindings = new List<KeyCodeEvents>();
    InputBindings.Add(IncreaseThrottle);
    InputBindings.Add(DecreaseThrottle);
    InputBindings.Add(RotateDesiredHeadingLeft);
    InputBindings.Add(RotateDesiredHeadingRight);
  }

  private void Update()
  {
    foreach (KeyCodeEvents inputBinding in InputBindings)
    {
      if (Input.GetKeyDown(inputBinding.KeyCodeReference.KeyCode))
      {
        inputBinding.KeyDown?.Invoke();
      }
      if (Input.GetKey(inputBinding.KeyCodeReference.KeyCode))
      {
        inputBinding.KeyHeld?.Invoke();
      }
      if (Input.GetKeyUp(inputBinding.KeyCodeReference.KeyCode))
      {
        inputBinding.KeyUp?.Invoke();
      }
    }
  }

}