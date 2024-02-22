using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;
using UnityEngine.UI;

public class SelectScene : MonoBehaviour
{
    [Header("name")]
    public TMP_InputField nameString;
    public Button nameSettingButton;

    [Header("character")]
    public GameObject characterBoard;
    public Button characterBoardButton;
    public Button characterSelect1Button;
    public Button characterSelect2Button;//characterSelectButton은 추후 배열로 바꿔주면 편할 듯
    [HideInInspector] public int characterIndex;

    private PlayerData playerData;

    private void Awake()
    {
        playerData = Json.Instance.GetPlayerData();
    }

    private void Start()
    {
        SettingButton();
    }

    //button--------------------------------------------
    private void SettingButton()
    {
        nameSettingButton.onClick.AddListener(() => SettingName());

        characterBoardButton.onClick.AddListener(() => OnCharacterSelectBoard());

        characterSelect1Button.onClick.AddListener(() => SettingCharacter(0));
        characterSelect1Button.onClick.AddListener(() => OffCharacterSelectBoard());

        characterSelect2Button.onClick.AddListener(() => SettingCharacter(1));
        characterSelect2Button.onClick.AddListener(() => OffCharacterSelectBoard());
    }

    public void SettingName()
    {
        if (!characterBoard.activeInHierarchy)
        {
            //이름 받아오는 중
            playerData.name = nameString.text;
            
            //선택한 정보 저장
            Json.Instance.SaveData(playerData);
            SceneManager.LoadScene("MainScene");
        }
    }
    
    public void OnCharacterSelectBoard()
    {
        characterBoard.SetActive(true);
    }

    public void OffCharacterSelectBoard()
    {
        characterBoard.SetActive(false);
    }

    public void SettingCharacter(int index)
    {
        characterIndex = index;
        playerData.characterIndex = characterIndex; //characterIndex를 통해 나타나는 캐릭터 이미지 변경 함수 생성
    }
}
