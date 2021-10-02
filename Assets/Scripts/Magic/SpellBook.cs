using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellBook : MonoBehaviour
{
    public List<SpellObject> Spells;
    
    public void CastRandomSpell()
    {
        var spell = Spells[Random.Range(0, Spells.Count)];        
        Destroy(Instantiate(spell.ParticleEffect, transform.position, Quaternion.identity, transform),spell.DamageType.Duration);
    }

    public void OnSpellCast(InputValue value)
    {
        CastRandomSpell();
    }
}
