using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject slotsParent;
    private bool[] check_item; //필요 없으면 삭제 
    private Item[] inventoryItem;

    public void MakeInventorySlot(int index)
    {
        check_item = new bool[index];
        inventoryItem = new Item[index];
        for (int i = 0; i < index; i++)
        {
            GameObject newSlot = Instantiate(GameManager.instance.inventorySlotF);
            newSlot.transform.parent = slotsParent.transform;
            GameManager.instance.inventorySlots[i] = newSlot;
            check_item[i] = false;
            inventoryItem[i] = null;
        }
    }

    public void ItemInInventory(Item item)
    {
        for(int i = 0;i < inventoryItem.Length; i++)
        {
            if (inventoryItem[i] == null)
            {
                inventoryItem[i] = item;
                check_item[i] = true;
                GameManager.instance.inventorySlots[i].transform.Find("UnEquip/item").GetComponent<Image>().sprite = inventoryItem[i].itemData.itemImage;
                GameManager.instance.inventorySlots[i].transform.Find("UnEquip/item").gameObject.SetActive(true);
                break;
            }
        }
    }

    public void UpdateInventory()
    {

    }
}
