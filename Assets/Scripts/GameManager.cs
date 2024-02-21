using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Player")]
    public GameObject character;
    [HideInInspector] public int level;
    [HideInInspector] public float levelExp;
    [HideInInspector] public int health;
    [HideInInspector] public int attack;
    [HideInInspector] public int defense;
    [HideInInspector] public float critical;
    [HideInInspector] public int coin;
    private CharacterInputController characterInputController;
    [HideInInspector] public CharacterLevel characterLevel;
    [HideInInspector] public CharacterHealth characterHealth;

    [Header("Inventory")]
    private Inventory inventory;
    [HideInInspector] public GameObject[] inventorySlots;
    public int inventorySlotCount;
    [HideInInspector] public bool change_status;


    public Item testItem;
    private UIManager UiManager;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        inventory = GetComponent<Inventory>();
        characterInputController = character.GetComponent<CharacterInputController>();
        characterLevel = character.GetComponent<CharacterLevel>();
        characterHealth = character.GetComponent<CharacterHealth>();

        UiManager = GetComponentInChildren<UIManager>();
    }

    private void Start()
    {
        StartCharacterSetting();
        UiManager.StartCharacterUISetting();

        characterHealth.MakecharacterHealth(health);

        inventorySlots = new GameObject[inventorySlotCount];
        inventory.MakeInventorySlot(inventorySlotCount);
        inventory.ItemInInventory(testItem);
    }

    private void Update()
    {
        if(change_status)
        {
            UiManager.ChageCharacterUISetting();
            change_status = false;
        }
    }

    private void StartCharacterSetting()
    {
        level = characterInputController.statusData.level;
        health = characterInputController.statusData.max_health;
        coin = characterInputController.statusData.coin;
        attack = characterInputController.statusData.attack;
        defense = characterInputController.statusData.defense;
        critical = characterInputController.statusData.critical;

        change_status = false;
    }
}
