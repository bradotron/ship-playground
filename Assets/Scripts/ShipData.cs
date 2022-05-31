using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ship/Ship Data")]
public class ShipData : ScriptableObject
{
  // ship stats
  // mass

  // Movement / Engine
  public float ThrottleChangePerSecond;
  public float DesiredHeadingChangePerSecond;
  public float RotationSpeedDegPerSecond;
  public float ManeuverAcceleration;
  public AnimationCurve ManeuverCurve;
  public float ThrustAcceleration;
  public AnimationCurve AccelerationCurve;
  public float Mass;
  public float MaximumSpeed;
  public float BrakingForce;
  public PIDControlTermsSO RotationPIDControlTerms;

  // do I put weapon slots in here? then create them via a 'Ship' script (it adds them as children to the prefab?)
}
