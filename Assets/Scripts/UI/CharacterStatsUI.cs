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
    public GameObject characterHealthParent;
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
            MakeCharaterHealth(i);
        }
    }

    private void Update()
    {
        
    }

    private void MakeCharaterHealth(int index)
    {
        float position_x = characterHealthParent.transform.position.x + 65 * index;
        float position_y = characterHealthParent.transform.position.y;
        Vector3 position = new Vector3(position_x, position_y, 0);
        GameObject newHeart = Instantiate(characterHealth, position, Quaternion.identity);
        newHeart.transform.parent = characterHealthParent.transform;
        Hearts[index] = newHeart;
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
