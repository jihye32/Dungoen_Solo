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
    //���� �Ŵ����� ��ӹ޴� ����?

    public GameObject[] characterPrefabs;
    public GameObject characterPosition;
    private GameObject character;

    [HideInInspector] public CharacterLevel characterLevel;
    [HideInInspector] public CharacterHealth characterHealth;
    
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
        //Json�� �̱����� �ߴµ� GameObject�� Json.cs�� �־�����ϴ� ����. -> GameManager.cs�� ���� ����... �ٵ� ���� ����?
        //Json �̱����� �ļ����� ����
        
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
