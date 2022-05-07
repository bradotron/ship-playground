using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipComponentsReferences : MonoBehaviour
{
  public Rigidbody2D rb2D;
  public PolygonCollider2D polygonCollider2D;
  private void Awake()
  {
    rb2D = GetComponent<Rigidbody2D>();
    polygonCollider2D = GetComponent<PolygonCollider2D>();
  }
  
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}
