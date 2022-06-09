using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleGuidanceComputer : IGuidanceComputer
{
  private GuidanceProperties currentGuidanceProperties;

  public void SetHeading(float heading)
  {
    currentGuidanceProperties.Heading = heading; 
  }

  public void Activate()
  {
    currentGuidanceProperties = new GuidanceProperties(0f, 0f);
  }

  public GuidanceProperties Compute()
  {
    return currentGuidanceProperties;
  }

  public void Deactivate()
  {
  }
}
