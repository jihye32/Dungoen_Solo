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


public class PlayerData
{
    public int characterIndex = 0;
    public string name;
    public int level = 1;
    public int coin = 1000;
    public int health = 10;
    public int exp = 0;
    public float levelexp;
    public float speed;
    public int attack;
    public int defense;
    public float critical;
}

//
public class Json
{
    /*
    Json 데이터 저장 방법
    PlayerData player = new PlayerData();
    string jsonData = JsonUtility.ToJson(player);
    Json 데이터 사용 방법
    PlayerData player2 = JsonUtility.FromJson<PlayerData>(jsonData);
    string name = player2.name;
    */

    private PlayerData playerData = new PlayerData();

    //유니티에서 알아서 만들어주는 경로 + /생성하는 파일 명
    string path = $"{Application.persistentDataPath}/save";

    private static Json instance;
    //프로퍼티를 이용한 싱글턴 -> AddComponent해주지 않아도 사용이 가능함.
    public static Json Instance 
    { 
        get 
        {
            if (instance == null) 
                instance = new Json();
           
            return instance;
        }
    }

    //data파일을 불러오기 위함. 여러번 사용하기 때문에 LoadData에는 적합하지 않음
    public PlayerData GetPlayerData()
    {
        return playerData;
    }

    //json 파일 저장하기
    public void SaveData(PlayerData Data)
    {
        playerData = Data;
        string data = JsonUtility.ToJson(playerData);

        //저장파일 생성. 외부에 저장.
        File.WriteAllText(path, data);
    }

    //json 파일 불러오기. mainScene에서 한번만 사용
    public void LoadData()
    {
        string data = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(data);
    }
}
