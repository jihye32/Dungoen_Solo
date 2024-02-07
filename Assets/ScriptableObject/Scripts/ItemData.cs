using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    atk, def
}

[CreateAssetMenu(fileName = "ItemData", menuName = "Data/Item", order = 2)]
public class ItemData : ScriptableObject
{
    [Header("Item Info")]
    public ItemType type;
    public Sprite itemImage;
    public int attack;
    public int defense;
    public float critical;
    public int plus_health;
}
