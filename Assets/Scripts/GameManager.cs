using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Character")]
    public GameObject player;
    private CharacterInputController characterInput;
    
    [Header("UI")]
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        characterInput = player.GetComponent<CharacterInputController>();
    }

    private void Start()
    {
        LevelText(characterInput.statsData.level);
        CoinText(characterInput.statsData.coin);
    }




    //UI
    public void LevelText(int level)
    {
        levelText.text = string.Format("Lv. {0}", level);
    }

    public void NameText(string inputText) //stat화면 생성 시 받는 부분
    {
        nameText.text = inputText;
    }

    public void CoinText(int coin)
    {
        coinText.text = coin.ToString();
    }
}
