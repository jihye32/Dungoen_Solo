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

    public void StartCharacterSetting(PlayerData playerData)
    {
        playerData.level = statusData.level;
        playerData.health = statusData.max_health;
        playerData.coin = statusData.coin; //코인은 playerData에 설정해뒀기 때문에 빼도 되지 않을까 싶음
        playerData.speed = statusData.speed;
        playerData.attack = statusData.attack;
        playerData.defense = statusData.defense;
        playerData.critical = statusData.critical;
        Json.Instance.SaveData(playerData);
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
