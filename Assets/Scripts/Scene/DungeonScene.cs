using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DungeonScene : MonoBehaviour
{
    PlayerData playerData;
    public GameObject[] characterPrefabs;
    public GameObject characterPosition;
    private GameObject character;

    [HideInInspector] public CharacterLevel characterLevel;
    [HideInInspector] public CharacterHealth characterHealth;

    private GameObject[] Enemys;
    public GameObject enemyPosition;


    private UIController UIcontroller;
    
    //������ ���� ��
    private int attack;
    private int defense;
    private float critical;
    //���� ��
    private int have_exp;
    private int level;
    private int coin;
    private int health;

    private void Awake()
    {
        Json.Instance.LoadData();
        playerData = Json.Instance.GetPlayerData();

        character = Instantiate(characterPrefabs[0]);
        character.GetComponent<PlayerInput>().enabled = false;
        characterLevel = character.GetComponent<CharacterLevel>();
        characterHealth = GetComponent<CharacterHealth>();

        UIcontroller = GetComponentInChildren<UIController>();
    }

    private void Start()
    {
        StartCharacterSetting();

        characterHealth.MakecharacterHealth(playerData.health);
        UIcontroller.StartCharacterUISetting(playerData);

        MakeEnemy(playerData.level);
    }

    private void StartCharacterSetting()
    {
        character.transform.position = characterPosition.transform.position;
    }

    //�� ����
    private void MakeEnemy(int playerLevel)
    {
        int index = UnityEngine.Random.Range(playerLevel, playerLevel + 2);
        Enemys = new GameObject[index];

        for(int i = 0; i < index; i++)
        {
            Enemys[i] = Resources.Load<GameObject>("Prefabs/object/Enemy");
            Vector3 position = new Vector3(enemyPosition.transform.position.x + i, enemyPosition.transform.position.y, enemyPosition.transform.position.z); //for�� �ۿ� new ���ִ°� ����
            Instantiate(Enemys[i], position, Quaternion.identity, enemyPosition.transform);
            
        }
    }

    //������ player�� enemy�� ����




    public void SaveCharacterStats()
    {
        playerData.level = level;
        playerData.coin = coin;
        playerData.health = health;
        playerData.exp = have_exp;
        playerData.levelexp = characterLevel.levelUpExp[0];
        Json.Instance.SaveData(playerData);
    }
}
