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
    Json ������ ���� ���
    PlayerData player = new PlayerData();
    string jsonData = JsonUtility.ToJson(player);
    Json ������ ��� ���
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

        //����Ƽ���� �˾Ƽ� ������ִ� ��� + /�����ϴ� ���� ��
        path = Application.persistentDataPath + "/" + filename;
        Debug.Log(path);
    }

    //json ���� �����ϱ�
    public void SaveData()
    {
        string data = JsonUtility.ToJson(playerData);

        //�������� ����. �ܺο� ����.
        File.WriteAllText(path, data);
    }

    //json ���� �ҷ�����.
    public void LoadData()
    {
        string data = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(data);
    }

    //����� �� ��������
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

    //�ٲ�� ������ �� save
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
