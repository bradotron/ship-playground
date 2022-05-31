using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
  // potential state machine...
  // ManualControl (only really a thing for player controlled ship)
  //   GoToDesiredVelocity
  // AutopilotControl
  //   GoToPoint (if within approach distance, distance to decelerate to 0 will get us to the point, or close enough, start stopping)
  //   OrbitPointAtDistance (look at orbit video: https://www.youtube.com/watch?v=mQKGRoV_jBc&list=PL5KbKbJ6Gf982bozKUYrX9C4qN_IQYTXZ&index=4)
  //   KeepShipAtDistance (continually update the GoToPoint)
  enum ShipMovementMode
  {
    Manual,
    GoTo,
  }

  private ShipMovementMode CurrentMovementMode;
  private ShipData ShipData;
  private Rigidbody2D shipRb2D;

  // manual mode properties
  private float CommandedHeading;
  private Vector2 CommandedBearing;
  private Vector2 PreviousBearing;
  private Vector2 CurrentBearing;
  private float CommandedSpeed
  {
    get
    {
      return ShipData.MaximumSpeed * Throttle01;
    }
  }

  // autopilot properties
  private Vector2 DesiredVelocity;
  private float Throttle01;
  private float VelocityError = 0.1f;
  private Vector2 Destination;
  private PID RotationPID;

  private void Awake()
  {
    CurrentMovementMode = ShipMovementMode.GoTo;
    Destination = Vector2.zero;
  }

  private void Start()
  {
    SetComponentReferences();
    CommandedHeading = 0f;
    Throttle01 = 0f;
    Destination = shipRb2D.position;
  }

  private void SetComponentReferences()
  {
    shipRb2D = GetComponent<Rigidbody2D>();
    RotationPID = new PID(ShipData.RotationPIDControlTerms);
  }

  private float angleCounter = 0f;
  private float timer = 0f;
  private void Update()
  {
    // if (Input.GetMouseButtonDown(1))
    // {
    //   Destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    // }
    // if (Input.GetKeyDown(KeyCode.Alpha1))
    // {
    //   Debug.Log("throttle to 0");
    //   bool test = IsWithinStoppingDistance(Vector2.zero);
    //   Debug.Log("ship position" + shipRb2D.position);
    //   this.SetThrottle(0);
    // }
    // if (Input.GetKeyDown(KeyCode.Alpha2))
    // {
    //   Debug.Log("throttle to 1");
    //   this.SetThrottle(1);
    // }
  }

  private void FixedUpdate()
  {
    switch (CurrentMovementMode)
    {
      case ShipMovementMode.GoTo:
        DrawLineToDestination();
        DoGoToPoint();
        break;
      case ShipMovementMode.Manual:
        DoManualDriving();
        break;
      default:
        break;
    }
  }

  private void DoGoToPoint()
  {
    if (IsDestinationWithinStoppingDistance())
    {
      Throttle01 = 0f;
      StopShipIfApproximatelyStopped();
    }
    // compute new commanded heading
    CommandedHeading = Vector2ToDegree(Destination - shipRb2D.position);
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

  private float DistanceToDestination()
  {
    return (Destination - shipRb2D.position).magnitude;
  }

  private float DistanceToZeroSpeed()
  {
    return 0f;
  }

  private void DoManualDriving()
  {
    RotateToCommandedHeading();
    AccelerateOrDeccelerate();
    AddManueverForce();
    StopShipIfApproximatelyStopped();
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
    Vector2 Acceleration = transform.right * ShipData.ThrustAcceleration;
    Vector2 NewVelocityRotatedToThrustDirection = shipRb2D.velocity + Acceleration * Time.fixedDeltaTime;

    if (NewVelocityRotatedToThrustDirection.magnitude > CommandedSpeed)
    {
      Acceleration = Acceleration.normalized * ((CommandedSpeed - shipRb2D.velocity.magnitude) / Time.fixedDeltaTime);
    }

    shipRb2D.AddForce(shipRb2D.mass * Acceleration * Time.fixedDeltaTime, ForceMode2D.Impulse);
  }

  private void AddManueverForce()
  {
    float forceSign = Mathf.Sign(Vector2.SignedAngle(shipRb2D.velocity, (Destination - shipRb2D.position)));

    shipRb2D.AddForce(shipRb2D.mass * (transform.up * forceSign * ShipData.ManeuverAcceleration) * Time.fixedDeltaTime, ForceMode2D.Impulse);
  }

  private void RotateToCommandedHeading()
  {
    float HeadingError = Vector2.SignedAngle(transform.right, DegreeToVector2(CommandedHeading));
    float maxTorque = ShipData.RotationSpeedDegPerSecond * Mathf.Deg2Rad * shipRb2D.inertia;
    float rotationPIDOutput = Mathf.Clamp(RotationPID.GetOutput(HeadingError, Time.fixedDeltaTime), -maxTorque, maxTorque);
    shipRb2D.AddTorque(rotationPIDOutput, ForceMode2D.Force);
  }
  private void DrawRayOfCurrentVelocity()
  {
    Debug.DrawLine(shipRb2D.position, shipRb2D.position + shipRb2D.velocity, Color.yellow);
  }

  private void DrawRayOfDesiredVelocity()
  {
    Debug.DrawLine(shipRb2D.position, shipRb2D.position + DesiredVelocity, Color.red);
  }

  private void DrawLineToDestination()
  {
    Debug.DrawLine(shipRb2D.position, Destination, Color.cyan);
  }

  public void SetShipData(ShipData shipData)
  {
    this.ShipData = shipData;
  }

  public bool AreVectorsWithinDegrees(Vector2 v1, Vector2 v2, float degrees)
  {
    return Mathf.Abs(Vector2.SignedAngle(v1, v2)) <= degrees;
  }

  public void RotateDesiredHeadingLeft()
  {
    CommandedHeading += ShipData.DesiredHeadingChangePerSecond * Time.deltaTime;
    CommandedHeading = AngleClamp360(CommandedHeading);
  }

  public void RotateDesiredHeadingRight()
  {
    CommandedHeading -= ShipData.DesiredHeadingChangePerSecond * Time.deltaTime;
    CommandedHeading = AngleClamp360(CommandedHeading);
  }

  public float AngleClamp360(float angle)
  {
    if (angle > 360f)
    {
      return angle % 360f;
    }

    if (angle < 0f)
    {
      return 360f + (angle % 360f);
    }

    return angle;
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

  public float Vector2ToRadian(Vector2 vector)
  {
    if (vector.y >= 0f)
    {
      return Mathf.Atan2(vector.y, vector.x);
    }
    else
    {
      return (2 * Mathf.PI) + Mathf.Atan2(vector.y, vector.x);
    }
  }

  public float Vector2ToDegree(Vector2 vector)
  {
    return Vector2ToRadian(vector) * Mathf.Rad2Deg;
  }

  public Vector2 RadianToVector2(float radian)
  {
    return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian)).normalized;
  }

  public Vector2 DegreeToVector2(float degree)
  {
    return RadianToVector2(degree * Mathf.Deg2Rad);
  }

  public void SetHeading(float heading)
  {
    CommandedHeading = AngleClamp360(heading);
  }


  public void SetThrottle(float throttle)
  {
    Throttle01 = Mathf.Clamp01(throttle); ;
  }

  public void IncreaseThrottle()
  {
    Throttle01 += (ShipData.ThrottleChangePerSecond / 100f) * Time.deltaTime;
    Throttle01 = Mathf.Clamp01(Throttle01);
  }

  public void DecreaseThrottle()
  {
    Throttle01 -= (ShipData.ThrottleChangePerSecond / 100) * Time.deltaTime;
    Throttle01 = Mathf.Clamp01(Throttle01);
  }

  public void SetDestinationToMouseWorldPosition()
  {
    Destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
  }
}
