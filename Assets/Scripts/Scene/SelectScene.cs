using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;
using UnityEngine.UI;

public class SelectScene : MonoBehaviour
{
    public TMP_InputField nameString;
    public Button nameSettingButton;

    public GameObject characterBoard;
    public Button characterBoardButton;
    public Button characterSelect1Button;
    public Button characterSelect2Button;
    [HideInInspector] public int characterIndex;

    private void Start()
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
            //Json.instance.을 누르면 왜 자동 완성으로 name이 나오는지.
            //근데 이 name을 사용하면 캐릭터 name으로 저장은 안됨.
            Json.instance.SetName(nameString.text);
            Json.instance.SetCharacter(characterIndex);
            Json.instance.SaveData();
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
    }
}
