using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Magic/Damage Type")]
public class DamageTypeSO : ScriptableObject
{
    public DamageType Type;
    public int Amount;
    public int Duration; // Damage over Time. 0 is instant damage
    
}

[Flags]
public enum DamageType
{
    Physical = 1,
    Earth = 2,
    Fire = 4,
    Air = 8,
    Water = 16,
    Light = 32,
    Dark = 64
}
