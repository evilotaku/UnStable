using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
  public GameObject Player;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    gameObject.transform.Rotate(new Vector3(Time.deltaTime * 60, Time.deltaTime * 60, 0));
  }

  private void OnTriggerEnter(Collider other)
  {
    if(other.gameObject == Player)
    {
      Player.GetComponent<PlayerManager>().HasKey = true;
      Destroy(gameObject);
    }
  }
}
