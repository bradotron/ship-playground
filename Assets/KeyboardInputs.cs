using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputs : MonoBehaviour
{
  public List<InputBinding> InputBindings;

  void Update()
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