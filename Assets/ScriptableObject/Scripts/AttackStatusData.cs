using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "AttackStatusData", menuName = "Data/StatusAttack", order = 1)]
public class AttackStatusData : DefaultStatusData
{
    [Header("Attack Info")]
    public int attack;
    public int defense;
    public float critical;
}
