using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInventory : MonoBehaviour
{
    private Item item;
    private bool input_check = false;
    private CharacterUI characterUI;

    private void Start()
    {
        characterUI = GameManager.instance.UI.GetComponent<CharacterUI>();
    }

    public void InInventoryItem()//매개변수 Item 받아야함.
    {
        item = new Item(5, 5);
        for (int j = 0; j < characterUI.inventoryItem.GetLength(0); j++)
        {
            for (int i = 0; i < characterUI.inventoryItem.GetLength(1); i++)
            {
                if (characterUI.inventoryItem[i, j].transform.Find("front").GetComponent<Image>().enabled)
                {
                    characterUI.inventoryItem[i, j].transform.Find("front").GetComponent<Image>().sprite = item.image;
                    characterUI.inventoryItem[i, j].transform.Find("front").gameObject.SetActive(true);
                    input_check = true;
                    break;
                }
            }
            if (input_check) break;
        }
    }
}
