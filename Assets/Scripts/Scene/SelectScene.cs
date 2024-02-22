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
    public Button characterSelect2Button;//characterSelectButton�� ���� �迭�� �ٲ��ָ� ���� ��
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
            //�̸� �޾ƿ��� ��
            playerData.name = nameString.text;
            
            //������ ���� ����
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
        playerData.characterIndex = characterIndex; //characterIndex�� ���� ��Ÿ���� ĳ���� �̹��� ���� �Լ� ����
    }
}
