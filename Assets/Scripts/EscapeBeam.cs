using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeBeam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnTriggerEnter(Collider other)
  {
    Follower follower = other.gameObject.GetComponent<Follower>();
    if(follower != null)
    {
      follower.IsEscaping = true;
    }
  }
}
