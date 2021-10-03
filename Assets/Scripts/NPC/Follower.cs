using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
  
  public GameObject Player;
  public float MinDistance = 75;
  public float AllowedDistance = 20;
  public float BufferDistance = 30;
  public float FollowSpeed = 0.2f;
  public RaycastHit Shot; // maybe raycast to check if animal can see you
  // Update is called once per frame
  void Update()
  {
    float distance = Vector3.Distance(transform.position, Player.transform.position);

    if (distance < BufferDistance)
    {
      // reset
    }
    else if (distance > AllowedDistance && distance < MinDistance)
    {
      transform.LookAt(Player.transform);
      transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, FollowSpeed);
    }
  }
}
