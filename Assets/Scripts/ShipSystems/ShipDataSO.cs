using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ship/Ship Data")]
public class ShipDataSO : ScriptableObject
{
  // ship stats
  public float Mass;

  // Movement / Engine
  public float ThrottleChangePerSecond;
  public float DesiredHeadingChangePerSecond;
  public float RotationSpeedDegPerSecond;
  public float ManeuverAcceleration;
  public float ThrustAcceleration;
  public float MaximumSpeed;
  public PIDControlTermsSO RotationPIDControlTerms;

  // do I put weapon slots in here? then create them via a 'Ship' script (it adds them as children to the prefab?)
}
