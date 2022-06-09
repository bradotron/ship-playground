using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualGuidanceComputer : IGuidanceComputer
{
  // change to float references
  private readonly float HeadingChangePerSecond = 60f;
  private readonly float ThrottleChangePerSecond = 0.5f;
  private GuidanceProperties CurrentGuidanceProperties;

  public void Activate()
  {
    // if (keyboardInputEvents == null)
    // {
    //   Debug.Log("events is null");
    // }

    // keyboardInputEvents.IncreaseThrottle.KeyHeld.AddListener(this.IncreaseThrottle);
    // keyboardInputEvents.DecreaseThrottle.KeyHeld.AddListener(this.DecreaseThrottle);
    // keyboardInputEvents.RotateDesiredHeadingLeft.KeyHeld.AddListener(this.RotateCommandedHeadingLeft);
    // keyboardInputEvents.RotateDesiredHeadingRight.KeyHeld.AddListener(this.RotateCommandedHeadingRight);
  }

  public void Deactivate()
  {
    // keyboardInputEvents.IncreaseThrottle.KeyHeld.RemoveListener(this.IncreaseThrottle);
    // keyboardInputEvents.DecreaseThrottle.KeyHeld.RemoveListener(this.DecreaseThrottle);
    // keyboardInputEvents.RotateDesiredHeadingLeft.KeyHeld.RemoveListener(this.RotateCommandedHeadingLeft);
    // keyboardInputEvents.RotateDesiredHeadingRight.KeyHeld.RemoveListener(this.RotateCommandedHeadingRight);
  }

  public GuidanceProperties Compute()
  {
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
