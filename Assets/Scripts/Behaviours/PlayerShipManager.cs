using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipManager : MonoBehaviour
{
  public GameObject PlayerShipGO { private set; get; }

  public void EnablePlayerShip()
  {
    PlayerShipGO.SetActive(true);
  }

  public void DisablePlayerShip()
  {
    PlayerShipGO.SetActive(false);
  }

  public void ChangePlayerShip(ShipSO ship)
  {
    
  }
  
}
