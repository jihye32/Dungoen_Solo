using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private EnemyAttack enemyAttack;
    int enemy_health;
    int enemy_defense;

    private void Awake()
    {
        enemyAttack = GetComponent<EnemyAttack>();
    }

    private void Start()
    {
        enemy_health = enemyAttack.attackData.max_health;
        enemy_defense = enemyAttack.attackData.defense;
    }

    //플레이어 공격에 데미지 받음.
    public void OnDamage(int playerattack)
    {
        int attack = playerattack / enemy_defense;
        enemy_health -= attack;
        if(enemy_health <= 0) 
        {
            OnDie();
        }
    }

    //죽음
    private void OnDie()
    {
        Destroy(gameObject);
    }
}
