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
        //Json.instance.을 누르면 왜 자동 완성으로 name이 나오는지.
        //근데 이 name을 사용하면 캐릭터 name으로 저장은 안됨.
        Json.instance.SetName(nameString.text);
        Json.instance.SaveData();
        SceneManager.LoadScene("MainScene");
    }
}
