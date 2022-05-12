using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
  public GameObject SelectedVisual;
  public bool IsSelected { get; private set; }
  private bool HasVisual;
  private void Awake()
  {
    HasVisual = SelectedVisual != null;
    IsSelected = false;
    UpdateVisual();
  }

  public void Select()
  {
    IsSelected = true;
    UpdateVisual();
  }

  public void Deselect()
  {
    IsSelected = false;
    UpdateVisual();
  }

  private void UpdateVisual()
  {
    if (HasVisual)
    {
      SelectedVisual.SetActive(IsSelected);
    }
  }
}
