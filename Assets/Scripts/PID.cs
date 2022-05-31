using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PID
{
  private PIDControlTermsSO PIDControlTerms;
  private float P, I, D;
  private float prevError;

  public PID(PIDControlTermsSO pIDControlTerms)
  {
    PIDControlTerms = pIDControlTerms;
  }
  public float GetOutput(float currentError, float deltaTime)
  {
    P = currentError;
    I += P * deltaTime;
    D = (P - prevError) / deltaTime;
    prevError = currentError;

    return P * PIDControlTerms.Kp + I * PIDControlTerms.Ki + D * PIDControlTerms.Kd;
  }

  public void ResetIntegral()
  {
    I = 0f;
  }
}
