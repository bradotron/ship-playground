using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipInitializer : MonoBehaviour
{
  [SerializeField] private ShipDictionarySO ShipDictionarySO;
  private Ship Ship;
  private GameObject ActivePlayerShip;
  private KeyboardInputEvents KeyboardInputs;
  private MouseInputEvents MouseInputs;
  private ShipMovement ActiveShipMovement;
  private Rigidbody2D ActiveShipRb2d;

  void Start()
  {
    // where should this happen? maybe create a PlayerInitialization Script?
    SetActiveShip(ShipDictionarySO.Destroyer);

    InitializeReferences();
    InitializePlayerShip();
    InitializeShipMovement();
    ConnectInputsToShipMovement();
  }


  public void SetActiveShip(Ship ship)
  {
    Ship = ship;
  }

  private void InitializeReferences()
  {
    KeyboardInputs = GetComponent<KeyboardInputEvents>();
    MouseInputs = GetComponent<MouseInputEvents>();
  }

  private void InitializePlayerShip()
  {
    if (ActivePlayerShip == null)
    {
      // no player ship in the scene
      ActivePlayerShip = Instantiate(Ship.Prefab, Vector3.zero, Quaternion.identity);
      ActiveShipRb2d = ActivePlayerShip.GetComponent<Rigidbody2D>();
      ActiveShipRb2d.mass = Ship.ShipData.Mass;

      // make thie 'Player' a child to the ship, so it moves with it
      transform.SetParent(ActivePlayerShip.transform);
    }
    else
    {
      // ship exists, maybe I've implemented docking or something?
      // just set active maybe?
    }
  }

  private void InitializeShipMovement()
  {
    ActiveShipMovement = ActivePlayerShip.GetComponent<ShipMovement>();
    ActiveShipMovement.SetShipData(Ship.ShipData);
  }

  private void ConnectInputsToShipMovement()
  {
    KeyboardInputs.IncreaseThrottle.KeyHeld.AddListener(ActiveShipMovement.IncreaseThrottle);
    KeyboardInputs.DecreaseThrottle.KeyHeld.AddListener(ActiveShipMovement.DecreaseThrottle);
    KeyboardInputs.RotateDesiredHeadingLeft.KeyHeld.AddListener(ActiveShipMovement.RotateDesiredHeadingLeft);
    KeyboardInputs.RotateDesiredHeadingRight.KeyHeld.AddListener(ActiveShipMovement.RotateDesiredHeadingRight);
    
    MouseInputs.RightClickUp.AddListener(ActiveShipMovement.SetDestinationToMouseWorldPosition);
  }
}
