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
        image = Resources.Load<Sprite>("Weapon-Sword");
        MakeItemDictionary("Weapon-Sword", attack, defense);
    }

    public void OnInstallItem()
    {
        if (!gameObject.transform.Find("front").GetComponent<Image>().enabled)
        {
            Item item;
            items.TryGetValue(gameObject.transform.Find("front").GetComponent<Image>().sprite.name.ToString(), out item);
            GameManager.instance.player_attack += item.attack;
            GameManager.instance.player_defense += item.defense;
        }
    }

    private void MakeItemDictionary(string image, float attack, float defense)
    {
        Item item = new Item(attack, defense);
        items.Add(image, item);
    }

}
