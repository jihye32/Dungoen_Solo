using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "AttackStatusData", menuName = "Data/StatusAttack", order = 1)]
public class AttackStatusData : DefaultStatusData
{
    [Header("Attack Info")]
    public float attack;
    public float defense;
    public float critical;
}
