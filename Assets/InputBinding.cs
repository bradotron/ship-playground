using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class InputBinding
{
  public KeyCodeReference KeyCodeReference;
  public UnityEvent KeyDown;
  public UnityEvent KeyHeld;
  public UnityEvent KeyUp;
}
