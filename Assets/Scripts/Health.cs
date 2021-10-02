using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth;

    public void DealDamage(DamageType _type, int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0) Die();

    }

    void Die()
    {
        Destroy(this);
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
