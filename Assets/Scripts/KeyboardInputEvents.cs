using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputEvents : MonoBehaviour
{
  public InputBinding IncreaseThrottle;
  public InputBinding DecreaseThrottle;
  public InputBinding RotateDesiredHeadingLeft;
  public InputBinding RotateDesiredHeadingRight;
  private List<InputBinding> InputBindings;


  private void Awake()
  {
    InputBindings = new List<InputBinding>();
    InputBindings.Add(IncreaseThrottle);
    InputBindings.Add(DecreaseThrottle);
    InputBindings.Add(RotateDesiredHeadingLeft);
    InputBindings.Add(RotateDesiredHeadingRight);
  }

  private void Update()
  {
    foreach (InputBinding inputBinding in InputBindings)
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