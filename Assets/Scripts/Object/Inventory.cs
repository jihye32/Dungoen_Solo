using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject slotsParent;
    private GameObject slot;
    private Item[] inventoryItem;
    private int select_slot;

    private void Awake()
    {
        select_slot = -1;
        slot = Resources.Load<GameObject>("Prefabs/slot");
    }

    private void Update()
    {
        if(select_slot != -1)
        {
            UseItem(select_slot);
            select_slot = -1;
        }
    }

    public void MakeInventorySlot(int index)
    {
        inventoryItem = new Item[index];
        for (int i = 0; i < index; i++)
        {
            GameObject newSlot = Instantiate(slot);
            newSlot.transform.parent = slotsParent.transform;
            GameManager.instance.inventorySlots[i] = newSlot;
            inventoryItem[i] = null;

            //파라미터값 변경 -----------------------------------------------------------------------------------------------------------------------------
            //AddListener은 onClick에 함수를 넣어줌.
            //정수형 변수를 for문 안에 선언하여 실행될 함수의 파라미터에 넣어줌. i로 하거나 for문 밖으로 정수를 선언할 경우 차례대로 들어가지 않음. 
            int n = i;
            GameManager.instance.inventorySlots[i].GetComponent<Button>().onClick.AddListener(() => OnSelectSlot(n));
        }
    }
    
    public void ItemInInventory(Item item)
    {
        for (int i = 0; i < inventoryItem.Length; i++)
        {
            if (inventoryItem[i] == null)
            {
                inventoryItem[i] = item;
                GameManager.instance.inventorySlots[i].transform.Find("UnEquip/item").GetComponent<Image>().sprite = inventoryItem[i].itemData.itemImage;
                GameManager.instance.inventorySlots[i].transform.Find("Equip/item").GetComponent<Image>().sprite = inventoryItem[i].itemData.itemImage;
                GameManager.instance.inventorySlots[i].transform.Find("UnEquip/item").gameObject.SetActive(true);
                break;
            }
        }
    }

    public void UseItem(int index)
    {
        if (inventoryItem[index] != null && !inventoryItem[index].equip)
        {
            inventoryItem[index].equip = true;
            GameManager.instance.attack += inventoryItem[index].itemData.attack;
            GameManager.instance.defense += inventoryItem[index].itemData.defense;
            GameManager.instance.critical += inventoryItem[index].itemData.critical;
            GameManager.instance.health += inventoryItem[index].itemData.plus_health;
            GameManager.instance.inventorySlots[index].transform.Find("Equip").gameObject.SetActive(true);
            GameManager.instance.change_status = true;
        }
        else if (inventoryItem[index] != null && inventoryItem[index].equip)
        {
            inventoryItem[index].equip = false;
            GameManager.instance.attack -= inventoryItem[index].itemData.attack;
            GameManager.instance.defense -= inventoryItem[index].itemData.defense;
            GameManager.instance.critical -= inventoryItem[index].itemData.critical;
            GameManager.instance.health -= inventoryItem[index].itemData.plus_health;
            GameManager.instance.inventorySlots[index].transform.Find("Equip").gameObject.SetActive(false);
            GameManager.instance.change_status = true;
        }
    }

    //인벤토리 슬롯 선택
    public void OnSelectSlot(int index)
    {
        select_slot = index;
    }
}
