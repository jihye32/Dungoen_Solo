using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public AttackStatusData statusData;

    public float[] levelUpExp = new float[2];
    public float levelup_plusExp;


    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

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


    //InputData
    protected void moveMent(Vector2 direction)
    {
        direction = direction * statusData.speed;
        rigidBody.velocity = direction;
    }

    protected bool interAction()
    {
        return true;
    }

    
}
