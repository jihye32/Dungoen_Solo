using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLevel : MonoBehaviour
{
    public float[] levelUpExp = new float[2];
    public float levelup_plusExp;

    private void Start()
    {
        levelUpExp[0] = 12;
        levelUpExp[1] = 25;
    }

    public void LevelUp()
    {
        GameManager.instance.level++;
        GameManager.instance.levelExp = 0;
        LevelExpSetting();
    }

    private void LevelExpSetting()
    {
        levelup_plusExp = levelUpExp[0] + levelUpExp[1];
        levelUpExp[0] = levelUpExp[1];
        levelUpExp[1] = levelup_plusExp;
    }
}
