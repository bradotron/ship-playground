using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CameraControls : MonoBehaviour
{
  private CinemachineVirtualCamera VirtualCamera;
  public Transform DefaultTarget;
  public bool IsZoomInverted = false;
  public float MouseWheelDeltaMulti = 2f;
  public float LerpTimeMax = 0.5f;
  private float CurrentLerpTime = 0f;
  public float MinimumOrthographicSize = 10f;
  public float MaximumOrthographicSize = 100f;
  private float OriginalOrthographicSize;
  private float TargetOrthographicSize;

  private void Awake()
  {
    VirtualCamera = GetComponent<CinemachineVirtualCamera>();
    if (VirtualCamera == null)
    {
      throw new System.Exception("virtrualCamera must be set.");
    }

    if (DefaultTarget != null)
    {
      VirtualCamera.Follow = DefaultTarget;
    }

    TargetOrthographicSize = MinimumOrthographicSize;
  }

  private void Update()
  {
    if (!IsAtTargetOrthographicSize())
    {
      UpdateOrthographicSize();
    }
  }

  public void Follow(Transform transform)
  {
    VirtualCamera.Follow = DefaultTarget;
  }

  public void FollowDefaultTarget()
  {
    VirtualCamera.Follow = DefaultTarget;
  }

  public void MouseWheelZoomIn()
  {
    ChangeTargetOrthographicSizeBy(-1 * MouseWheelDeltaMulti);
  }

  public void MouseWheelZoomOut()
  {
    ChangeTargetOrthographicSizeBy(1 * MouseWheelDeltaMulti);
  }

  public void ChangeTargetOrthographicSizeBy(float delta)
  {
    TargetOrthographicSize += (IsZoomInverted ? -1 : 1) * delta;
    TargetOrthographicSize = Mathf.Clamp(TargetOrthographicSize, MinimumOrthographicSize, MaximumOrthographicSize);
    CurrentLerpTime = 0f;
    OriginalOrthographicSize = VirtualCamera.m_Lens.OrthographicSize;
  }

  private bool IsAtTargetOrthographicSize()
  {
    return VirtualCamera.m_Lens.OrthographicSize == TargetOrthographicSize;
  }

  private void UpdateOrthographicSize()
  {
    VirtualCamera.m_Lens.OrthographicSize = Mathf.Lerp(OriginalOrthographicSize, TargetOrthographicSize, CurrentLerpTime / LerpTimeMax);
    CurrentLerpTime = Mathf.Clamp(CurrentLerpTime + Time.deltaTime, 0f, LerpTimeMax);
  }
}