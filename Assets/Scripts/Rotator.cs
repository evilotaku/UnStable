using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
  private Vector3 _rotation = new Vector3(0, 10, 0);
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    this.transform.Rotate(_rotation * Time.deltaTime);
  }
}
