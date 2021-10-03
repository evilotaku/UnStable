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
        spell.Cast(gameObject);      
           
    }

    public void OnSpellCast(InputValue value)
    {
        CastRandomSpell();
    }
}
