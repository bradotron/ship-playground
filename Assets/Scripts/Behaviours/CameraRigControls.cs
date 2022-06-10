using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraRigControls : MonoBehaviour
{
  [SerializeField] private InputReader inputReader;
  [SerializeField] private CinemachineVirtualCamera VirtualCamera;
  // have a CameraFollowEventChannel that will raise events with a Transform

  // these config values can all be reference SO's, that can be changed in like a settings menu or something
  private bool IsZoomInverted = false;
  private float MouseWheelDeltaMulti = 2f;
  private float LerpTimeMax = 0.5f;
  private float CurrentLerpTime = 0f;
  private float MinimumOrthographicSize = 10f;
  private float MaximumOrthographicSize = 100f;
  private float OriginalOrthographicSize;
  private float TargetOrthographicSize;

  private void Awake()
  {
    TargetOrthographicSize = MinimumOrthographicSize;
  }

  private void OnEnable()
  {
    inputReader.MouseWheelZoomEvent += OnMouseWheelZoomEvent;
  }

  private void OnDisable()
  {
    inputReader.MouseWheelZoomEvent -= OnMouseWheelZoomEvent;
  }

  private void Update()
  {
    if (!IsAtTargetOrthographicSize())
    {
      UpdateOrthographicSize();
    }
  }

  public void OnMouseWheelZoomEvent(float zoom)
  {
    ChangeTargetOrthographicSizeBy(zoom * MouseWheelDeltaMulti);
  }

  private void ChangeTargetOrthographicSizeBy(float delta)
  {
    TargetOrthographicSize += (IsZoomInverted ? 1 : -1) * delta;
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