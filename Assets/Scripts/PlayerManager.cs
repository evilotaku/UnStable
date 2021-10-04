using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
  public bool HasKey = false;
  private SphereCollider _FreedomRadius;
    // Start is called before the first frame update
    void Start()
    {
    _FreedomRadius = GetComponent<SphereCollider>();
    
    }

    // Update is called once per frame
    void Update()
    {
        //if(_FreedomRadius.enabled) _FreedomRadius.enabled = false;
  }

  public void OnUseKey(InputValue value)
  {
    if (!HasKey) return;
    _FreedomRadius.enabled = true;
    StartCoroutine(DisableFreedomRadius());
  }

  public void OnTriggerEnter(Collider other)
  {
    Follower follower = other.gameObject.GetComponent<Follower>();
    if (follower != null)
    {
      follower.IsPenned = false;
    }
  }

  private IEnumerator DisableFreedomRadius()
  {
    yield return new WaitForSeconds(1);
    _FreedomRadius.enabled = false;
  }
}
