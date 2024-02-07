using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player")]


    [Header("UI")]
    public GameObject statusButton;
    public GameObject inventoryButton;
    public GameObject statusUI;
    public GameObject inventoryUI;


    [Header("Inventory")]
    public GameObject inventorySlotF;
    [HideInInspector] public GameObject[] inventorySlots;
    public int inventorySlotCount;
    private Inventory inventory;
    public Item testItem;






    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        inventory = GetComponent<Inventory>();
    }

    private void Start()
    {
        inventorySlots = new GameObject[inventorySlotCount];
        inventory.MakeInventorySlot(inventorySlotCount);
        inventory.ItemInInventory(testItem);
    }
}
