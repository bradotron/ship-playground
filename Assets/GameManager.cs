using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  [SerializeField] private InputReader inputReader = default;
  // Start is called before the first frame update
  void Start()
  {
    inputReader.EnableGameplayInputs();
  }
}
