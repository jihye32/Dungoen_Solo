using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class DungeonScene : MonoBehaviour
{
    //���� �Ŵ����� ��ӹ޴� ����?

    public GameObject[] characterPrefabs;
    public GameObject characterPosition;
    private GameObject character;

    [HideInInspector] public CharacterLevel characterLevel;
    [HideInInspector] public CharacterHealth characterHealth;

    //�߰��ؾ��� �� : ĳ���� ����, �̸�, ������, ���� UI ���� / attack, defense, critical ��������



    private void Awake()
    {
        Json.instance.LoadData();

        character = Instantiate(characterPrefabs[0]);
        characterLevel = character.GetComponent<CharacterLevel>();
        characterHealth = GetComponent<CharacterHealth>();
    }

    private void Start()
    {
        StartCharacterSetting();
        StartCharacterUISetting();

        characterHealth.MakecharacterHealth(Json.instance.GetHealth());
    }

    private void StartCharacterSetting()
    {
        character.transform.position = characterPosition.transform.position;
    }

    private void StartCharacterUISetting()
    {
        //throw new NotImplementedException();
    }
}
