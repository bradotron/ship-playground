using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntReference
{
  [SerializeField] private IntVariableSO Variable;
  public int Value
  {
    get
    {
      return Variable.Value;
    }
  }
}
