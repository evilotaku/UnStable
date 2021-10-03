using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Magic/Effects")]
public class EffectSO : ScriptableObject
{
    public EffectType _type;
    public GameObject particleEffect;
    public float Duration;
    [Range(-1,1)] //% modifier
    public int Strength; //positive Buff, Negative Debuff


}

[Flags]
public enum EffectType
{
    Movement = 1, 
    Armor = 2,
    Mana = 4
}
