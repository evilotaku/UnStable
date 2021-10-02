using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellBook : MonoBehaviour
{
    public List<SpellObject> Spells;
    void Start()
    {
        
    }
    
    public void CastRandomSpell()
    {
        var spell = Spells[Random.Range(0, Spells.Count)]; 
        spell.Targets.caster = gameObject; 
        print($"{spell.Targets.caster} is casting {spell.name}");                     
        spell.Cast();
        foreach (var target in spell.Targets.Get())
        {
            print($"{target.name} targeted by spell!");
            if(target.gameObject == gameObject) return;
            target.DealDamage(spell.Damage.Type, spell.Damage.Amount);
        } 
           
    }

    public void OnSpellCast(InputValue value)
    {
        CastRandomSpell();
    }
}
