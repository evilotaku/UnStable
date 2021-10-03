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
    public AudioClip SoundEffect;
    public int ManaCost;
    public TargetTypeSO Targets;
    public DamageTypeSO Damage;
    public List<EffectSO> Effects;

    public void Cast(GameObject caster)
    { 
        caster.GetComponent<AudioSource>().PlayOneShot(SoundEffect);
        var effect =  Instantiate(ParticleEffect, Targets.caster.transform.position, Quaternion.LookRotation(Targets.caster.transform.forward));
        Destroy(effect, Damage.Duration);   
        Debug.Log("Effect Instantiated");
        foreach (var target in Targets.Get())
        {
            Debug.Log($"{target.name} targeted by spell!");
            if(target.gameObject == caster) return;
            target.DealDamage(Damage.Type, Damage.Amount);
            foreach (var _effect in Effects)
            {                
                target.StartCoroutine(target.StatusEffect(_effect._type, _effect.Duration, _effect.Strength));                          
                Destroy(Instantiate(_effect.particleEffect, target.transform.position,Quaternion.identity), _effect.Duration);
            }  
        } 

           
    }
}
