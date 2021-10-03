using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float Mana;

    public float DamageMod = 0;


    StarterAssets.ThirdPersonController _controller;

    public void DealDamage(DamageType _type, int amount)
    {
        currentHealth -= amount - (amount*DamageMod);
        if(currentHealth <= 0) Die();

    }


    public IEnumerator StatusEffect(EffectType _type, float duration, int strength)
    {
        var currentMove = _controller.MoveSpeed;
        var currentDamageMod = DamageMod;
        if(_type == EffectType.Movement)
        {
            _controller.MoveSpeed += (strength*currentMove);
        }
        if(_type == EffectType.Armor)
        {
            DamageMod = strength;
        }
        

        yield return new WaitForSeconds(duration);

        _controller.MoveSpeed = currentMove;
        DamageMod = currentDamageMod;
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
