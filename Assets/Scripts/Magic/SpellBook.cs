using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellBook : MonoBehaviour
{
    public List<SpellObject> Spells;
    public List<AudioClip> voices;
    public AudioClip footsteps;
    Animator animator;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }
    
    public void CastRandomSpell()
    {
        var spell = Spells[Random.Range(0, Spells.Count)]; 
        spell.Targets.caster = gameObject; 
        print($"{spell.Targets.caster} is casting {spell.name}");                     
        spell.Cast(gameObject);
        audio.PlayOneShot(voices[Random.Range(0, voices.Count)]);      
           
    }

    public void OnSpellCast(InputValue value)
    {
        CastRandomSpell();
    }

    void Update()
    {
        if(animator.GetFloat("Speed") > 1)
        {
            audio.clip = footsteps;
            audio.Play();
        } 
    }
}
