using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class DungeonScene : MonoBehaviour
{
    PlayerData playerData;
    public GameObject[] characterPrefabs;
    public GameObject characterPosition;
    private GameObject character;

    [HideInInspector] public CharacterLevel characterLevel;
    [HideInInspector] public CharacterHealth characterHealth;
    
    //변하지 않을 것
    private int attack;
    private int defense;
    private float critical;
    //변할 것
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
    }

    private void Start()
    {
        StartCharacterSetting();

        characterHealth.MakecharacterHealth(playerData.health);
    }

    private void StartCharacterSetting()
    {
        character.transform.position = characterPosition.transform.position;
    }

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
