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

    public int GetLevel()
    {
        return playerData.level;
    }

    public int GetCoin()
    {
        return playerData.coin;
    }

    public int GetHealth()
    {
        return playerData.health;
    }

    public int GetExp()
    {
        return playerData.exp;
    }
    public float GetLevelExp()
    {
        return playerData.levelexp;
    }

    public float GetSpeed()
    {
        return playerData.speed;
    }

    public int GetAttack()
    {
        return playerData.attack;
    }

    public int GetDefense()
    {
        return playerData.defense;
    }

    public float GetCritical()
    {
        return playerData.critical;
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
    public void SetLevelExp(float levelexp)
    {
        playerData.levelexp = levelexp;
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
