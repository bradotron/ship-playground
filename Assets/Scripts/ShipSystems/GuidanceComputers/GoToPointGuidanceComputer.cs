using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToPointGuidanceComputer : IGuidanceComputer
{
  private ShipDataSO ShipData;
  private Rigidbody2D shipRb2D;
  private Vector2 Destination;

  public void SetShipData(ShipDataSO shipData)
  {
    ShipData = shipData;
  }

  public void SetShipRb2d(Rigidbody2D ship)
  {
    shipRb2D = ship;
  }

  public void SetDestination(Vector2 destination)
  {
    Destination = destination;
  }

  public void Activate()
  {
    // what needs to get set here? any event hookups yes?
  }

  public GuidanceProperties Compute()
  {
    return new GuidanceProperties(
      IsDestinationWithinStoppingDistance() ? 0f : 1f,
      AngleUtilities.Vector2ToDegree(Destination - shipRb2D.position)
    );
  }

  public void Deactivate()
  {
    // disconnect anything that was set up in activate
  }


  private bool IsDestinationWithinStoppingDistance()
  {
    float distanceToDestination = (Destination - shipRb2D.position).magnitude;
    float distanceUntilStopped = (shipRb2D.velocity.magnitude * shipRb2D.velocity.magnitude) / (2 * ShipData.ThrustAcceleration);
    if (distanceToDestination <= distanceUntilStopped)
    {
      return true;
    }
    return false;
  }
}
