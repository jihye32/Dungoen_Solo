using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatsUI : MonoBehaviour
{
    //체력바 생성 및 수정
    public GameObject characterHealth;
    public GameObject characterHalfHealth;
    private GameObject[] Hearts;
    private int hearts_count;


    //캐릭터 스탯 UI
    public GameObject characterStatsUI;
    

    private void Start()
    {
        hearts_count = GameManager.instance.player_health;
        Hearts = new GameObject[hearts_count];
        for (int i = 0; i < Hearts.Length; i++)
        {
            float position_y = transform.position.y + 65 * i;
            GameObject newHeart = MakeCharaterHealth(position_y);
            Hearts[i] = newHeart;
        }
    }

    private void Update()
    {
        
    }

    private GameObject MakeCharaterHealth(float position_y)
    {
        transform.position = new Vector3(transform.position.x, position_y, 0);
        return Instantiate(characterHealth,transform.position,Quaternion.identity);
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
