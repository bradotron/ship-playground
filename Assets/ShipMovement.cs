using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
  [SerializeField] private float Throttle;
  [SerializeField] private float DesiredHeading;
  public float ThrottleChangePerSecond = 25f;
  public float RotationChangePerSecont = 30f;

  // Start is called before the first frame update
  void Start()
  {
    // this is where we should set ship movement parameters based on the current ship
  }

  // Update is called once per frame
  void Update()
  {
    if (Throttle > 0)
    {

    }
    else
    {

    }
  }

  private void Rotate()
  {

  }

  private void Thrust()
  {

  }

  public void SetHeading(float heading)
  {

  }


  public void SetThrottle(float throttle)
  {
    Throttle = Mathf.Clamp(throttle, 0f, 100f); ;
  }

  public void IncreaseThrottle()
  {
    Throttle += ThrottleChangePerSecond * Time.deltaTime;
    Throttle = Mathf.Clamp(Throttle, 0f, 100f);
  }

  public void DecreaseThrottle()
  {
    Throttle -= ThrottleChangePerSecond * Time.deltaTime;
    Throttle = Mathf.Clamp(Throttle, 0f, 100f);
  }
}
