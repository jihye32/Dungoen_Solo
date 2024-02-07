using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject slotsParent;
    private GameObject slot;
    private bool[] check_item; //필요 없으면 삭제 
    private Item[] inventoryItem;
    

    private void Start()
    {
        slot = Resources.Load<GameObject>("Prefabs/slot");
    }

    public void MakeInventorySlot(int index)
    {
        check_item = new bool[index];
        inventoryItem = new Item[index];
        for (int i = 0; i < index; i++)
        {
            GameObject newSlot = Instantiate(slot);
            newSlot.transform.parent = slotsParent.transform;
            GameManager.instance.inventorySlots[i] = newSlot;
            check_item[i] = false;
            inventoryItem[i] = null;
        }
        ChangeParameter();
    }
    
    public void ItemInInventory(Item item)
    {
        for (int i = 0; i < inventoryItem.Length; i++)
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






    //파라미터 변경
    public void ChangeParameter()
    {
        for(int i = 0; i <  inventoryItem.Length; i++)
        {
            //AddListener은 onClick에 함수를 넣어줌.
            //정수형 변수를 for문 안에 선언하여 실행될 함수의 파라미터에 넣어줌. i로 하거나 for문 밖으로 정수를 선언할 경우 차례대로 들어가지 않음. 
            int n = i;
            GameManager.instance.inventorySlots[i].GetComponent<Button>().onClick.AddListener(() => OnSelectSlot(n));
        }
    }

    //인벤토리 슬롯 선택
    public void OnSelectSlot(int index)
    {
        Debug.Log(index);
    }
}
