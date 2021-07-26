using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
  //private variables used for player control
  private float speed = 15.0f;
  private float turnSpeed = 30.0f;
  private float horizontalInput;
  private float forwardInput;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Move the vehicle forward using player input
    forwardInput = Input.GetAxis("Vertical2");
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

    //Move the vehicle left and right using player input
    horizontalInput = Input.GetAxis("Horizontal2");
    transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
  }
}
