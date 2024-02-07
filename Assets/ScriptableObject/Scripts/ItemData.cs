using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Data/Item", order = 2)]
public class ItemData : ScriptableObject
{
    [Header("Item Info")]
    public float attack;
    public float defense;
    public float critical;
}
