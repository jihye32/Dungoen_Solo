using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectScene : MonoBehaviour
{
    public TMP_InputField nameString;
    public Button nameSettingButton;

    private void Start()
    {
        nameSettingButton.onClick.AddListener(() => SettingName());
    }

    public void SettingName()
    {
        //Json.instance.�� ������ �� �ڵ� �ϼ����� name�� ��������.
        //�ٵ� �� name�� ����ϸ� ĳ���� name���� ������ �ȵ�.
        Json.instance.SetName(nameString.text);
        Json.instance.SaveData();
        SceneManager.LoadScene("MainScene");
    }
}
