using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float speed = 5.0f;
  public float turnSpeed = 2.0f;
  public float horizontalInput;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Move the vehicle forward
    transform.Translate(Vector3.forward * Time.deltaTime * speed);

    //Move the vehicle left and right using player input
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
  }
}
