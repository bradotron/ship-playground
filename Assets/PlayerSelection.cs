using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
  public Selectable SelectedObject { private set; get; }

  public void Awake()
  {
    SelectedObject = null;
  }

  public void SelectObjectAtMousePosition()
  {
    Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Collider2D[] colliders = Physics2D.OverlapCircleAll(mouseWorldPosition, 0.5f);

    if (colliders.Length > 0)
    {
      foreach (Collider2D collider in colliders)
      {
        if (collider.TryGetComponent<Selectable>(out Selectable selectable))
        {
          SetSelectedObjectTo(selectable);
        }
      }
    }
    else
    {
      DeselectSelectedObject();
    }

  }

  public void SetSelectedObjectTo(Selectable selectable)
  {
    DeselectSelectedObject();
    SelectedObject = selectable;
    SelectedObject.Select();
  }

  public void DeselectSelectedObject()
  {
    if (SelectedObject != null)
    {
      SelectedObject.Deselect();
      SelectedObject = null;
    }
  }

}
