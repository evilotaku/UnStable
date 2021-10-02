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
    public DamageTypeSO DamageType;
}
