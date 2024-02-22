using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public ItemData itemData;
    [HideInInspector] public int attack;
    [HideInInspector] public int defense;
    [HideInInspector] public float critical;
    [HideInInspector] public int health;
    [HideInInspector] public bool equip;

    public Item(ItemData itemData)
    {
        attack = itemData.attack;
        defense = itemData.defense;
        critical = itemData.critical;
        health = itemData.plus_health;
        equip = false;
    }
}
