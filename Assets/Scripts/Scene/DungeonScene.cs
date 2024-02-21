using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class DungeonScene : MonoBehaviour
{
    //게임 매니저를 상속받는 것은?

    public GameObject[] characterPrefabs;
    public GameObject characterPosition;
    private GameObject character;

    [HideInInspector] public CharacterLevel characterLevel;
    [HideInInspector] public CharacterHealth characterHealth;

    //추가해야할 것 : 캐릭터 레벨, 이름, 레벨바, 코인 UI 연결 / attack, defense, critical 가져오기



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
