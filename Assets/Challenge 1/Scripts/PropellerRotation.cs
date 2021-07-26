using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
  // propellers rotation speed
  private float rotationSpeed = 720.0f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // rotate the propeller
    transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
  }
}
