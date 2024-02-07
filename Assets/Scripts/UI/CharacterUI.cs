using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUI : MonoBehaviour
{
    ////체력바 생성 및 수정
    //public GameObject characterHealth;
    //public GameObject characterHalfHealth;
    //public GameObject characterHealthParent;
    //private GameObject[] Hearts;
    //private int hearts_count;


    ////캐릭터 버튼 UI
    //public GameObject characterStatsUI;
    //public GameObject characterStatsButton;
    //public TextMeshProUGUI characterAttackText;
    //public TextMeshProUGUI characterDefenseText;
    //public TextMeshProUGUI characterCriticalText;
    //public TextMeshProUGUI characterHealthText;

    //public GameObject characterInventoryUI;
    //public GameObject characterInventoryButton;
    //public GameObject characterInventorySlot;
    //public GameObject characterInventoryParent;
    //public GameObject[,] inventoryItem;
    //private CharacterInventory inventory;

    //private void Awake()
    //{
    //    inventory = GameManager.instance.player.GetComponent<CharacterInventory>();
    //}

    //private void Start()
    //{
    //    hearts_count = GameManager.instance.player_health;
    //    Hearts = new GameObject[hearts_count];
    //    inventoryItem = new GameObject[4,4];
    //    for (int i = 0; i < Hearts.Length; i++)
    //    {
    //        MakeCharaterHealth(i);
    //    }
    //    for (int i = 0; i < inventoryItem.GetLength(0); i++)
    //    {
    //        for(int j = 0; j < inventoryItem.GetLength(1); j++)
    //        {
    //            MakeInventorySlot(j, i);
    //        }
    //    }
    //    inventory.InInventoryItem();
    //}

    //private void Update()
    //{
    //    characterAttackText.text = GameManager.instance.player_attack.ToString();
    //    characterDefenseText.text = GameManager.instance.player_defense.ToString();
    //    characterHealthText.text = GameManager.instance.player_health.ToString();
    //    characterCriticalText.text = GameManager.instance.player_critical.ToString();
    //}

    //private void MakeCharaterHealth(int index)
    //{
    //    float position_x = characterHealthParent.transform.position.x + 65 * index;
    //    float position_y = characterHealthParent.transform.position.y;
    //    Vector3 position = new Vector3(position_x, position_y, 0);
    //    GameObject newHeart = Instantiate(characterHealth, position, Quaternion.identity);
    //    newHeart.transform.parent = characterHealthParent.transform;
    //    Hearts[index] = newHeart;
    //}

    //private void MakeInventorySlot(int index1, int index2)
    //{
    //    float position_x = characterInventoryParent.transform.position.x + 120 * index1;
    //    float position_y = characterInventoryParent.transform.position.y - 120 * index2;
    //    Vector3 position = new Vector3(position_x, position_y, 0);
    //    GameObject newSlot = Instantiate(characterInventorySlot, position, Quaternion.identity);
    //    newSlot.transform.parent = characterInventoryParent.transform;
    //    inventoryItem[index1, index2] = newSlot;
    //}
}
