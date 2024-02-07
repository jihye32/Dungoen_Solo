using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject slotsParent;
    private GameObject slot;
    private bool[] check_item; //�ʿ� ������ ���� 
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






    //�Ķ���� ����
    public void ChangeParameter()
    {
        for(int i = 0; i <  inventoryItem.Length; i++)
        {
            //AddListener�� onClick�� �Լ��� �־���.
            //������ ������ for�� �ȿ� �����Ͽ� ����� �Լ��� �Ķ���Ϳ� �־���. i�� �ϰų� for�� ������ ������ ������ ��� ���ʴ�� ���� ����. 
            int n = i;
            GameManager.instance.inventorySlots[i].GetComponent<Button>().onClick.AddListener(() => OnSelectSlot(n));
        }
    }

    //�κ��丮 ���� ����
    public void OnSelectSlot(int index)
    {
        Debug.Log(index);
    }
}
