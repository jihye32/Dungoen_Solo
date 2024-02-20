using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DefaultStatusData", menuName ="Data/StatusDefault", order = 0)]
public class DefaultStatusData : ScriptableObject
{
    [Header("Stats Info")]
    public int level;
    public int max_health;
    public int exp;
    public int coin;
    public float speed;
}
