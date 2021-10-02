using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        var effect =  Instantiate(ParticleEffect, Targets.caster.transform.position, Quaternion.identity);
        Destroy(effect, Damage.Duration);   
        Debug.Log("Effect Instantiated");     
    }
}
