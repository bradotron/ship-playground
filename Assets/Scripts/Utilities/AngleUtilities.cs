using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AngleUtilities
{
  public static float Clamp360(float angle)
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

  public static bool AreVectorsWithinDegrees(Vector2 v1, Vector2 v2, float degrees)
  {
    return Mathf.Abs(Vector2.SignedAngle(v1, v2)) <= degrees;
  }

  public static float Vector2ToRadian(Vector2 vector)
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

  public static float Vector2ToDegree(Vector2 vector)
  {
    return Vector2ToRadian(vector) * Mathf.Rad2Deg;
  }

  public static Vector2 RadianToVector2(float radian)
  {
    return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian)).normalized;
  }

  public static Vector2 DegreeToVector2(float degree)
  {
    return RadianToVector2(degree * Mathf.Deg2Rad);
  }
}
