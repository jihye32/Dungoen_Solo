using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/*
  1. ������ ������ ���� (�ڵ� = Ŭ����)
  2. �����͸� ���̽����� ��ȯ
  ====================================
  ���̽� ����ϱ�
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
    Json ������ ���� ���
    PlayerData player = new PlayerData();
    string jsonData = JsonUtility.ToJson(player);
    Json ������ ��� ���
    PlayerData player2 = JsonUtility.FromJson<PlayerData>(jsonData);
    string name = player2.name;
    */

    private PlayerData playerData = new PlayerData();

    //����Ƽ���� �˾Ƽ� ������ִ� ��� + /�����ϴ� ���� ��
    string path = $"{Application.persistentDataPath}/save";

    private static Json instance;
    //������Ƽ�� �̿��� �̱��� -> AddComponent������ �ʾƵ� ����� ������.
    public static Json Instance 
    { 
        get 
        {
            if (instance == null) 
                instance = new Json();
           
            return instance;
        }
    }

    //data������ �ҷ����� ����. ������ ����ϱ� ������ LoadData���� �������� ����
    public PlayerData GetPlayerData()
    {
        return playerData;
    }

    //json ���� �����ϱ�
    public void SaveData(PlayerData Data)
    {
        playerData = Data;
        string data = JsonUtility.ToJson(playerData);

        //�������� ����. �ܺο� ����.
        File.WriteAllText(path, data);
    }

    //json ���� �ҷ�����. mainScene���� �ѹ��� ���
    public void LoadData()
    {
        string data = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(data);
    }
}
