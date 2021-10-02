using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Magic/Spell")]
public class SpellObject : ScriptableObject
{
    public int Id;
    public string Name;
    public Texture2D Icon;
    public GameObject ParticleEffect;
    public int ManaCost;
    public TargetTypeSO Targets;
    public DamageTypeSO Damage;

    public void Cast()
    {    
        Destroy(Instantiate(ParticleEffect, Targets.Get()[0].transform.position, Quaternion.identity, Targets.caster.transform),Damage.Duration);   
        foreach (var target in Targets.Get())
        {
            if(Targets.caster == target.gameObject) return;
            target.DealDamage(Damage.Type, Damage.Amount);
        } 
                
    }
}
