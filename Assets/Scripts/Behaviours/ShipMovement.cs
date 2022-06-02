using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// create a PlayerShipMovement that has manual guiddance and also autopilot guidances
// create NPCShipMovement that only has auto pilots, and then eventually we'll do some fake brain that sets targets and things
public class ShipMovement : MonoBehaviour
{

  private IGuidanceComputer activeGuidance;
  private GuidanceProperties currentGuidanceProperties;
  private ShipDataSO ShipData;
  private Rigidbody2D shipRb2D;
  private Vector2 Destination;
  private float CommandedHeading;
  private float Throttle01;
  private float CommandedSpeed
  {
    get
    {
      return ShipData.MaximumSpeed * Throttle01;
    }
  }

  private PID RotationPID;

  private void Awake()
  {
    currentGuidanceProperties = new GuidanceProperties(0f, 0f);
  }

  private void Start()
  {
    SetComponentReferences();
    CommandedHeading = 0f;
    Throttle01 = 0f;
  }

  private void SetComponentReferences()
  {
    shipRb2D = GetComponent<Rigidbody2D>();
    RotationPID = new PID(ShipData.RotationPIDControlTerms);
  }
  
  public void SetShipData(ShipDataSO shipData)
  {
    this.ShipData = shipData;
  }

  public void SetActiveGuidanceComputer(IGuidanceComputer computer)
  {
    if (activeGuidance != null)
    {
      activeGuidance.Deactivate();
    }
    activeGuidance = computer;
    activeGuidance.Activate();
  }
  private void FixedUpdate()
  {
    currentGuidanceProperties = activeGuidance.Compute();
    HandleMovementTowardsGuidanceProperties();
    AddManueverForce();
  }


  private void HandleMovementTowardsGuidanceProperties()
  {
    CommandedHeading = currentGuidanceProperties.Heading;
    Throttle01 = currentGuidanceProperties.Throttle;

    RotateToCommandedHeading();
    AccelerateOrDeccelerate();
    AddManueverForce();
  }

  private void DoGoToPoint()
  {
    if (IsDestinationWithinStoppingDistance())
    {
      Throttle01 = 0f;
      StopShipIfApproximatelyStopped();
    }
    // compute new commanded heading
    CommandedHeading = AngleUtilities.Vector2ToDegree(Destination - shipRb2D.position);
    RotateToCommandedHeading();
    AccelerateOrDeccelerate();
    AddManueverForce();
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

  private void AccelerateOrDeccelerate()
  {
    if (shipRb2D.velocity.magnitude > CommandedSpeed)
    {
      DeccelerateToCommandedSpeed();
    }
    else
    {
      AccelerateToCommandedSpeed();
    }
  }

  private void StopShipIfApproximatelyStopped()
  {
    if (Mathf.Approximately(Throttle01, 0f) && Mathf.Approximately(0f, shipRb2D.velocity.magnitude))
    {
      SetShipVelocityToZero();
    }
  }

  private void DeccelerateToCommandedSpeed()
  {
    Debug.Log("Deccelerate");
    Vector2 Decceleration = -shipRb2D.velocity.normalized * ShipData.ThrustAcceleration;
    Vector2 NewVelocity = shipRb2D.velocity + Decceleration * Time.fixedDeltaTime;
    if (NewVelocity.magnitude < CommandedSpeed)
    {
      Decceleration = Decceleration.normalized * ((CommandedSpeed - shipRb2D.velocity.magnitude) / Time.fixedDeltaTime);
    }
    shipRb2D.AddForce(shipRb2D.mass * Decceleration * Time.fixedDeltaTime, ForceMode2D.Impulse);
  }

  private void AccelerateToCommandedSpeed()
  {
    Debug.Log("Accelerate");
    Vector2 Acceleration = transform.right * ShipData.ThrustAcceleration;
    Vector2 NewVelocityRotatedToThrustDirection = shipRb2D.velocity + Acceleration * Time.fixedDeltaTime;

    if (NewVelocityRotatedToThrustDirection.magnitude > CommandedSpeed)
    {
      Acceleration = Acceleration.normalized * ((CommandedSpeed - shipRb2D.velocity.magnitude) / Time.fixedDeltaTime);
    }

    shipRb2D.AddForce(shipRb2D.mass * Acceleration * Time.fixedDeltaTime, ForceMode2D.Impulse);
  }

  private void RotateToCommandedHeading()
  {
    float HeadingError = Vector2.SignedAngle(transform.right, AngleUtilities.DegreeToVector2(CommandedHeading));
    float maxTorque = ShipData.RotationSpeedDegPerSecond * Mathf.Deg2Rad * shipRb2D.inertia;
    float rotationPIDOutput = Mathf.Clamp(RotationPID.GetOutput(HeadingError, Time.fixedDeltaTime), -maxTorque, maxTorque);
    shipRb2D.AddTorque(rotationPIDOutput, ForceMode2D.Force);
  }

  private void AddManueverForce()
  {
    float forceSign = Mathf.Sign(Vector2.SignedAngle(shipRb2D.velocity, transform.right));

    shipRb2D.AddForce(shipRb2D.mass * (transform.up * forceSign * ShipData.ManeuverAcceleration) * Time.fixedDeltaTime, ForceMode2D.Impulse);
  }

  public bool IsStopped()
  {
    if (shipRb2D.velocity.magnitude < 0.001 && shipRb2D.velocity.magnitude > -0.001f)
    {
      SetShipVelocityToZero();
      return true;
    }
    else
    {
      return false;
    }
  }

  public void SetShipVelocityToZero()
  {
    shipRb2D.velocity = Vector2.zero;
  }

  public void SetDestinationToMouseWorldPosition()
  {
    Destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
  }
}
