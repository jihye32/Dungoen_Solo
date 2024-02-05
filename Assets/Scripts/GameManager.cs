using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Character")]
    public GameObject player;
    private CharacterInputController characterInput;
    public int player_health { get; private set; }
    public int player_level { get; private set; }
    public int player_coin { get; private set; }

    [Header("UI")]
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI coinText;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        characterInput = player.GetComponent<CharacterInputController>();
        player_health = characterInput.statsData.max_health;
        player_level = characterInput.statsData.level;
        player_coin = characterInput.statsData.coin;
    }

    private void Start()
    {
        
        LevelText(player_level);
        CoinText(player_coin);
    }

    private void Update()
    {
    }

    private void LevelUp()
    {
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
