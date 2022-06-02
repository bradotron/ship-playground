using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Guidance Computers/Manual")]
public class ManualGuidanceComputer : ScriptableObject, IGuidanceComputer
{
  // change to float references
  private readonly float HeadingChangePerSecond = 60f;
  private readonly float ThrottleChangePerSecond = 0.5f;
  private GuidanceProperties CurrentGuidanceProperties;

  private KeyCodeEvents IncreaseThrottleEvents;
  private KeyCodeEvents DecreaseThrottleEvents;
  private KeyCodeEvents RotateCommandedHeadingLeftEvents;
  private KeyCodeEvents RotateCommandedHeadingRightEvents;

  public void Activate()
  {
    IncreaseThrottleEvents.KeyHeld.AddListener(this.IncreaseThrottle);
    DecreaseThrottleEvents.KeyHeld.AddListener(this.DecreaseThrottle);
    RotateCommandedHeadingLeftEvents.KeyHeld.AddListener(this.RotateCommandedHeadingLeft);
    RotateCommandedHeadingRightEvents.KeyHeld.AddListener(this.RotateCommandedHeadingRight);
  }

  public void Deactivate()
  {
    IncreaseThrottleEvents.KeyHeld.RemoveListener(this.IncreaseThrottle);
    DecreaseThrottleEvents.KeyHeld.RemoveListener(this.DecreaseThrottle);
    RotateCommandedHeadingLeftEvents.KeyHeld.RemoveListener(this.RotateCommandedHeadingLeft);
    RotateCommandedHeadingRightEvents.KeyHeld.RemoveListener(this.RotateCommandedHeadingRight);
  }

  public void SetInputEvents(KeyCodeEvents increaseThrottle, KeyCodeEvents decreaseThrottle, KeyCodeEvents rotateLeft, KeyCodeEvents rotateRight) {
    IncreaseThrottleEvents = increaseThrottle;
    DecreaseThrottleEvents = decreaseThrottle;
    RotateCommandedHeadingLeftEvents = rotateLeft;
    RotateCommandedHeadingRightEvents = rotateRight;
  }

  public GuidanceProperties Compute()
  {
    // Debug.Log("Computing manual guidance: " + CurrentGuidanceProperties.Heading + " | " + CurrentGuidanceProperties.Throttle);
    return CurrentGuidanceProperties;
  }

  public void SetCommandedHeading(float heading)
  {
    CurrentGuidanceProperties.Heading = AngleUtilities.Clamp360(heading);
  }

  public void RotateCommandedHeadingLeft()
  {
    CurrentGuidanceProperties.Heading = AngleUtilities.Clamp360(CurrentGuidanceProperties.Heading + (HeadingChangePerSecond * Time.deltaTime));
  }

  public void RotateCommandedHeadingRight()
  {
    CurrentGuidanceProperties.Heading = AngleUtilities.Clamp360(CurrentGuidanceProperties.Heading - (HeadingChangePerSecond * Time.deltaTime));
  }

  public void SetThrottle(float throttle)
  {
    CurrentGuidanceProperties.Throttle = Mathf.Clamp01(throttle);
  }

  public void IncreaseThrottle()
  {
    CurrentGuidanceProperties.Throttle = Mathf.Clamp01(CurrentGuidanceProperties.Throttle + (ThrottleChangePerSecond * Time.deltaTime));
  }

  public void DecreaseThrottle()
  {
    CurrentGuidanceProperties.Throttle = Mathf.Clamp01(CurrentGuidanceProperties.Throttle - (ThrottleChangePerSecond * Time.deltaTime));
  }
}
