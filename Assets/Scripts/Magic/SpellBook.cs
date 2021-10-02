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
        spell.Targets.caster = gameObject;               
        spell.Cast();
    }

    public void OnSpellCast(InputValue value)
    {
        CastRandomSpell();
    }
}
