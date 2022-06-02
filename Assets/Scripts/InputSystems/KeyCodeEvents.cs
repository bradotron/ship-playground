using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class KeyCodeEvents
{
  public KeyCodeReferenceSO KeyCodeReference;
  public UnityEvent KeyDown;
  public UnityEvent KeyHeld;
  public UnityEvent KeyUp;
}
