using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ship/Ship")]
public class Ship : ScriptableObject
{
  [SerializeField] public ShipData ShipData;
  [SerializeField] private PrefabReferenceSO PrefabReferenceSO;

  public GameObject Prefab
  {
    get { return PrefabReferenceSO.Prefab; }
  }
}
