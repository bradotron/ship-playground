using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipGuidanceComputers
{
  public IdleGuidanceComputer Idle;
  public ManualGuidanceComputer Manual;
  public GoToPointGuidanceComputer GoTo;

  public PlayerShipGuidanceComputers()
  {
    Idle = new IdleGuidanceComputer();
    Manual = new ManualGuidanceComputer();
    GoTo = new GoToPointGuidanceComputer();
  }
}
