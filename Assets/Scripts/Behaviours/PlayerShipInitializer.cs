using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipInitializer : MonoBehaviour
{
  [SerializeField] private ShipDictionarySO ShipDictionarySO;
  [SerializeField] private PlayerShipGuidanceComputers playerShipGuidanceComputers;
  
  private ShipSO Ship;
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
  }


  public void SetActiveShip(ShipSO ship)
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

    // set guidance computer dictionary into ship movement here

    // gotta setup the inputs for manual guidance
    playerShipGuidanceComputers.Manual.SetInputEvents(KeyboardInputs.IncreaseThrottle, KeyboardInputs.DecreaseThrottle, KeyboardInputs.RotateDesiredHeadingLeft, KeyboardInputs.RotateDesiredHeadingRight);
    
    
    ActiveShipMovement.SetActiveGuidanceComputer(playerShipGuidanceComputers.Manual);
  }
}
