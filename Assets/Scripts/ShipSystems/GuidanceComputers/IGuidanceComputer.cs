using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GuidanceProperties
{
  public GuidanceProperties(float heading, float throttle)
  {
    Heading = heading;
    Throttle = throttle;
  }
  public float Heading; // 0 to 360
  public float Throttle; // 0 to 1
}

public interface IGuidanceComputer
{
  public void Activate();
  public void Deactivate();
  public GuidanceProperties Compute();
}
