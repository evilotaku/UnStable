using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Magic/Targets")]
public class TargetTypeSO : ScriptableObject
{
    public TargetType Type;
    public int Range;
}

[Flags]
public enum TargetType
{
    Self = 1,
    AOE = 2,
    Projectile = 4,
    Direct = 8

}
