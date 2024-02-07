using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player")]
    public GameObject character;
    [HideInInspector] public int level;
    [HideInInspector] public int health;
    [HideInInspector] public int attack;
    [HideInInspector] public int defense;
    [HideInInspector] public float critical;
    [HideInInspector] public int coin;
    private CharacterInputController characterInputController;

    [Header("UI")]
    public GameObject statusButton;
    public GameObject inventoryButton;
    public GameObject statusUI;
    public GameObject inventoryUI;
    public TMP_Text levelText;
    public TMP_Text attackText;
    public TMP_Text defenseText;
    public TMP_Text healthText;
    public TMP_Text criticalText;
    public TMP_Text coinText;


    [Header("Inventory")]
    private Inventory inventory;
    public GameObject[] inventorySlots;
    public int inventorySlotCount;


    public Item testItem;


    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        inventory = GetComponent<Inventory>();
        characterInputController = character.GetComponent<CharacterInputController>();
    }

    private void Start()
    {
        StartCharacterSetting();
        inventorySlots = new GameObject[inventorySlotCount];
        inventory.MakeInventorySlot(inventorySlotCount);
        inventory.ItemInInventory(testItem);
    }

    private void StartCharacterSetting()
    {
        level = characterInputController.statusData.level;
        health = characterInputController.statusData.max_health;
        coin = characterInputController.statusData.coin;
        attack = characterInputController.statusData.attack;
        defense = characterInputController.statusData.defense;
        critical = characterInputController.statusData.critical;

        levelText.text = string.Format("Lv. {0}", level);
        healthText.text = health.ToString();
        coinText.text = coin.ToString("N0");
        attackText.text = attack.ToString();
        defenseText.text = defense.ToString();
        criticalText.text = critical.ToString();
    }

}
