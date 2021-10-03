using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellPickUp : MonoBehaviour
{
    public SpellObject spell;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            spell.Cast(col.gameObject);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
