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
  public bool IsEscaping;
  public bool IsPenned = true;

  public PlayerManager PM;
  

  private void Start()
  {
    PM = Player.GetComponent<PlayerManager>();
    if (!IsPenned)
      transform.rotation = Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0));
  }

  void Update()
  {
    if(IsEscaping)
    {
      gameObject.GetComponent<Rigidbody>().useGravity = false;
      var vec = gameObject.transform.position;
      gameObject.transform.position = new Vector3(vec.x, vec.y + 0.2f, vec.z);
      return;
    }

    float distance = Vector3.Distance(transform.position, Player.transform.position);

    if (distance < BufferDistance)
    {
      // reset
    }
    else if (!IsPenned && distance > AllowedDistance && distance < MinDistance)
    {
      transform.LookAt(Player.transform);
      transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, FollowSpeed);
    }
  }
}
