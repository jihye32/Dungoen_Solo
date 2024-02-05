using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatsUI : MonoBehaviour
{
    private GameManager gameManager = GameManager.instance;

    //ü�¹� ���� �� ����
    public GameObject characterHealth;
    public GameObject characterHalfHealth;
    private GameObject[] Hearts;
    private int hearts_count;


    //ĳ���� ���� UI
    public GameObject characterStatsUI;
    

    private void Start()
    {
        hearts_count = GameManager.instance.player_health;
        Hearts = new GameObject[hearts_count];
    }

    private void MakeCharaterHealth()
    {
        GameObject newHeart = Instantiate(characterHealth);
    }


    //Button
    public void OnClickCharacterStats()
    {
        characterStatsUI.SetActive(true);
    }

    public void OffClickCharacterStats()
    {
        characterStatsUI.SetActive(false);
    }
}
