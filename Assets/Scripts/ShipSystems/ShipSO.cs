using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ship/Ship")]
public class ShipSO : ScriptableObject
{
  [SerializeField] public ShipDataSO ShipData;
  [SerializeField] private PrefabReferenceSO PrefabReferenceSO;

  public GameObject Prefab
  {
    get { return PrefabReferenceSO.Prefab; }
  }
}
