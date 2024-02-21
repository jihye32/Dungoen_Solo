using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/*
  1. 저장할 데이터 생성 (코드 = 클래스)
  2. 데이터를 제이슨으로 변환
  ====================================
  제이슨 사용하기
 */


class PlayerData
{
    public int characterIndex;
    public string name;
    public int level;
    public int coin;
    public int health;
    public int exp;
    public float speed;
    public int attack;
    public int defense;
    public float critical;
}

public class Json : MonoBehaviour
{
    /*
    Json 데이터 저장 방법
    PlayerData player = new PlayerData();
    string jsonData = JsonUtility.ToJson(player);
    Json 데이터 사용 방법
    PlayerData player2 = JsonUtility.FromJson<PlayerData>(jsonData);
    string name = player2.name;
    */

    PlayerData playerData = new PlayerData();

    string path;
    string filename = "save";

    public static Json instance;

    private void Awake()
    {
        instance = this;

        //유니티에서 알아서 만들어주는 경로 + /생성하는 파일 명
        path = Application.persistentDataPath + "/" + filename;
        Debug.Log(path);
    }

    //json 파일 저장하기
    public void SaveData()
    {
        string data = JsonUtility.ToJson(playerData);

        //저장파일 생성. 외부에 저장.
        File.WriteAllText(path, data);
    }

    //json 파일 불러오기.
    public void LoadData()
    {
        string data = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(data);
    }

    //저장된 값 가져오기
    public int GetCharacter()
    {
        return playerData.characterIndex;
    }

    public string GetName()
    {
        return playerData.name;
    }

    public float GetSpeed()
    {
        return playerData.speed;
    }

    //바뀌는 데이터 값 save
    public void SetCharacter(int index)
    {
        playerData.characterIndex = index;
    }

    public void SetName(string name)
    {
        playerData.name = name;
    }

    public void SetLevel(int level)
    {
        playerData.level = level;
    }
    public void SetCoin(int coin)
    {
        playerData.coin = coin;
    }
    public void SetHealth(int health)
    {
        playerData.health = health;
    }
    public void SetExp(int exp)
    {
        playerData.exp = exp;
    }
    public void SetSpeed(float speed)
    {
        playerData.speed = speed;
    }

    public void SetAttack(int attack)
    {
        playerData.attack = attack;
    }
    public void SetDefense(int defense)
    {
        playerData.defense = defense;
    }
    public void SetCritical(float critical)
    {
        playerData.critical = critical;
    }
}
