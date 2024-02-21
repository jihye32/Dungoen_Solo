using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Player")]
    public GameObject[] characterPrefabs;
    public GameObject[] characterPosition;
    [HideInInspector] public GameObject character;
    [HideInInspector] public int level;
    [HideInInspector] public int levelExp;
    [HideInInspector] public int health;
    [HideInInspector] public float speed;
    [HideInInspector] public int attack;
    [HideInInspector] public int defense;
    [HideInInspector] public float critical;
    [HideInInspector] public int coin;
    private Character characterStats;
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

        Json.instance.LoadData();

        inventory = GetComponent<Inventory>();
        character = Instantiate(characterPrefabs[0]);
        characterStats = character.GetComponent<Character>();
        characterLevel = character.GetComponent<CharacterLevel>();
        characterHealth = GetComponent<CharacterHealth>();

        UiManager = GetComponentInChildren<UIManager>();
    }

    private void Start()
    {
        StartCharacterSetting();
        UiManager.StartCharacterUISetting();
        SaveCharacterStats();

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
        character.transform.parent = characterPosition[0].transform;
        character.transform.position = characterPosition[0].transform.position;

        level = characterStats.statusData.level;
        health = characterStats.statusData.max_health;
        coin = characterStats.statusData.coin;
        speed= characterStats.statusData.speed;
        attack = characterStats.statusData.attack;
        defense = characterStats.statusData.defense;
        critical = characterStats.statusData.critical;

        change_status = false;
    }

    //CharacterStats ¿˙¿Â
    public void SaveCharacterStats()
    {
        Json.instance.SetLevel(level);
        Json.instance.SetCoin(coin);
        Json.instance.SetHealth(health);
        Json.instance.SetExp(levelExp);
        Json.instance.SetSpeed(speed);
        Json.instance.SetAttack(attack);
        Json.instance.SetDefense(defense);
        Json.instance.SetCritical(critical);
        Json.instance.SaveData();
    }
}
