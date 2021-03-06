using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName ="Magic/Targets")]
public class TargetTypeSO : ScriptableObject
{
    public GameObject caster;
    public TargetType _type;
    public int TargetRange;
    public float EffectRadius = 1;

    public List<Health> Get()
    {       
        Vector3 origin = new Vector3(); 
        List<Health> targets = new List<Health>();
        if(_type.HasFlag(TargetType.Self))
        {
            origin = caster.transform.position;                   
        }

        
        foreach (var target in Physics.OverlapSphere(origin, EffectRadius))
        {
            var obj = target.GetComponent<Health>();
            if(obj != null) targets.Add(obj);
        } 
        Debug.Log($"{targets.Count} Health targets found");

        return targets;
    }
}

[Flags]
public enum TargetType
{
    Self = 1,
    AOE = 2,
    Direct = 4,
    LOS = 8,
    Projectile = 16

}
