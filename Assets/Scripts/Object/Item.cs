using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemData itemData;
    [HideInInspector] public int attack;
    [HideInInspector] public int defense;
    [HideInInspector] public float critical;
    [HideInInspector] public int health;

    public Item(ItemData itemData)
    {
        attack = itemData.attack;
        defense = itemData.defense;
        critical = itemData.critical;
        health = itemData.plus_health;
    }
}
