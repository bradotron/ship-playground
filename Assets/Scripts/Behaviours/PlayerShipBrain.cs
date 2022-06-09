using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerShipBrain : MonoBehaviour
{
  [SerializeField] private ShipDictionarySO ShipDictionarySO;
  [SerializeField] private InputReader inputReader;
  private ShipSO ActiveShipSO;
  private GameObject ActivePlayerShipGameObject;
  private ShipMovement ActiveShipMovement;
  private Rigidbody2D ActiveShipRb2D;
  private PlayerShipGuidanceComputerSelection PlayerShipGuidanceComputerSelection;

  private void Start()
  {
    // where should this happen? maybe create a PlayerInitialization Script?
    ChangePlayerShip(ShipDictionarySO.Destroyer);
    SpawnPlayerShipAt(Vector2.zero);
    // DisablePlayerShip();
    InitializeReferences();
    InitializeShipMovement();

  }

  private void EnablePlayerShip()
  {
    ActivePlayerShipGameObject.SetActive(true);
  }

  private void DisablePlayerShip()
  {
    ActivePlayerShipGameObject.SetActive(false);
  }

  private void InitializeReferences()
  {
    PlayerShipGuidanceComputerSelection = GetComponent<PlayerShipGuidanceComputerSelection>();
  }

  private void SpawnPlayerShipAt(Vector2 position)
  {
    // no player ship in the scene
    ActivePlayerShipGameObject = Instantiate(ActiveShipSO.Prefab, position, Quaternion.identity);
    ActiveShipRb2D = ActivePlayerShipGameObject.GetComponent<Rigidbody2D>();
    ActiveShipRb2D.mass = ActiveShipSO.ShipData.Mass;
    // make thie 'Player' a child to the ship, so it moves with it
    transform.SetParent(ActivePlayerShipGameObject.transform);
  }

  private void ChangePlayerShip(ShipSO newShipSO)
  {
    ActiveShipSO = newShipSO;
  }

  private void InitializeShipMovement()
  {
    ActiveShipMovement = ActivePlayerShipGameObject.GetComponent<ShipMovement>();
    ActiveShipMovement.SetShipData(ActiveShipSO.ShipData);
    ActiveShipMovement.SetActiveGuidanceComputer(PlayerShipGuidanceComputerSelection.SelectedGuidanceComputer);
  }

}
