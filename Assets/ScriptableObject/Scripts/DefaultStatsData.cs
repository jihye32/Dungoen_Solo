using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DefaultStatsData", menuName ="StatsData/Default", order = 0)]
public class DefaultStatsData : ScriptableObject
{
    [Header("Stats Info")]
    public int level;
    public float max_health;
    public int coin;
    public float speed;
}
