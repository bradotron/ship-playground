using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipGuidanceComputerSelection : MonoBehaviour
{
  private PlayerShipGuidanceComputers playerShipGuidanceComputers;
  public IGuidanceComputer SelectedGuidanceComputer { private set; get; }

  private void Awake()
  {
    playerShipGuidanceComputers = new PlayerShipGuidanceComputers();
    SelectedGuidanceComputer = playerShipGuidanceComputers.Manual;
  }

  // somehow the selection can be changed by inputs and/or UI events
}
