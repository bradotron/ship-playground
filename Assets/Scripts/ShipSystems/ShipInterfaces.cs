using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IShipMovementActions
{
  public void GoToAtDistance(Vector2 position, float distance);
  public void FollowAtDistance(Vector2 position, float distance);
  public void OrbitAtDistance(Vector2 position, float distance);
  public void SetHeading(float headingDegrees);
  public void SetThrottle(float headingDegrees);
  public void IncreaseThrottle();
  public void DecreaseThrottle();
  public void RotateHeadingLeft();
  public void RotateHeadingRight();
}

public interface IShipWeaponActions
{

}

public interface IShipInventoryActions
{

}

// also some like IShipInventoryActions

// interactions maybe?