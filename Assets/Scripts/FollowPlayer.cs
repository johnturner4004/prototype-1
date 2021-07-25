using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  // game object used to reverence vehicle in the camera position
  public GameObject player;
  //Offset to keep camera above and behind the vehicle
  private Vector3 offset = new Vector3(0, 5, -8);

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void LateUpdate()
  {
    // Offset the camera by adding to the players position
    transform.position = player.transform.position + offset;
  }
}
