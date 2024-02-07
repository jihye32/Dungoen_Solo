using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private float attack;
    private float defense;
    public Sprite image;
    private Dictionary<string, Item> items = new Dictionary<string, Item>();

    public Item(float attack, float defense)
    {
        this.attack = attack;
        this.defense = defense;
    }
}
