using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "AttackStatsData", menuName = "StatsData/Attack", order = 1)]
public class AttackStatsData : DefaultStatsData
{
    [Header("Attack Info")]
    public float attack;
    public float defense;
    public float critical;
}
