using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class Character : MonoBehaviour
{
    public AttackStatusData statusData;
    [HideInInspector] public CharacterLevel level;

    private void Awake()
    {
        level = GetComponent<CharacterLevel>();
    }

    public void StartCharacterSetting()
    {
        GameManager.instance.level = statusData.level;
        GameManager.instance.health = statusData.max_health;
        GameManager.instance.coin = statusData.coin;
        GameManager.instance.speed = statusData.speed;
        GameManager.instance.attack = statusData.attack;
        GameManager.instance.defense = statusData.defense;
        GameManager.instance.critical = statusData.critical;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //충돌 >> 이동
        if(collision.gameObject.tag == "EnterDungoen")
        {
            GameManager.instance.character.transform.position = new Vector3(31.5f, -3.5f, 0);
            GameManager.instance.GetComponent<Camera>().transform.position = new Vector3(40, 0, -10);
        }
        else if (collision.gameObject.tag == "GoMain")
        {
            GameManager.instance.character.transform.position = new Vector3(8.5f, -3.5f, 0);
            GameManager.instance.GetComponent<Camera>().transform.position = new Vector3(0, 0, -10);
        }
    }
}
