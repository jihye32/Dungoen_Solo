using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class DungeonScene : MonoBehaviour
{
    //게임 매니저를 상속받는 것은?

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
        //Json을 싱글턴을 했는데 GameObject에 Json.cs를 넣어줘야하는 이유. -> GameManager.cs랑 같은 이유... 근데 무슨 이유?
        //Json 싱글턴이 후순위인 이유
        
        character = Instantiate(characterPrefabs[0]);
        characterLevel = character.GetComponent<CharacterLevel>();
        characterHealth = GetComponent<CharacterHealth>();
    }

    private void Start()
    {
        Json.instance.LoadData();

        StartCharacterSetting();

        characterHealth.MakecharacterHealth(Json.instance.GetHealth());
    }

    private void StartCharacterSetting()
    {
        character.transform.position = characterPosition.transform.position;
    }

    public void SaveCharacterStats()
    {
        Json.instance.SetLevel(level);
        Json.instance.SetCoin(coin);
        Json.instance.SetHealth(health);
        Json.instance.SetExp(have_exp);
        Json.instance.SetLevelExp(characterLevel.levelUpExp[0]);
        Json.instance.SaveData();
    }
}
