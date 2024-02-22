using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Player")]
    PlayerData playerData;
    public GameObject[] characterPrefabs;
    public GameObject characterPosition;
    [HideInInspector] public GameObject character;

    private Character characterStats;
    [HideInInspector] public int level;
    [HideInInspector] public int levelExp;
    [HideInInspector] public int health;
    [HideInInspector] public float speed;
    [HideInInspector] public int attack;
    [HideInInspector] public int defense;
    [HideInInspector] public float critical;
    [HideInInspector] public int coin;
    

    [HideInInspector] public bool change_status = false;
    public Item testItem;
    public UIManager UiManager;
    public Camera _camera;


    public static GameManager instance;

    private void Awake()
    {
        //싱글턴
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(this);

        //Json 불러오기
        Json.Instance.LoadData();
        playerData = Json.Instance.GetPlayerData();

        _camera = Camera.main;

        //캐릭터 생성
        character = Instantiate(characterPrefabs[playerData.characterIndex]);
        character.transform.position = characterPosition.transform.position;

        characterStats = character.GetComponent<Character>();
    }

    private void Start()
    {
        //세팅 및 처음 스탯 저장
        characterStats.StartCharacterSetting(playerData);
        SaveCharacterStats();
    }

    private void Update()
    {
        if(change_status)
        {
            //UiManager.ChageCharacterUISetting();
            change_status = false;
        }
    }

    //CharacterStats 저장
    public void SaveCharacterStats()
    {
        playerData.level = level;
        playerData.coin = coin;
        playerData.health = health;
        playerData.exp = levelExp;
        playerData.levelexp = characterStats.level.levelUpExp[0];
        playerData.speed = speed;
        playerData.attack = attack;
        playerData.defense = defense;
        playerData.critical = critical;
        Json.Instance.SaveData(playerData);
    }
}
