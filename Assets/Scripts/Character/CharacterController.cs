using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public AttackStatsData statsData;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    //InputData
    protected void moveMent(Vector2 direction)
    {
        direction = direction * statsData.speed;
        rigidBody.velocity = direction;
    }

    protected bool interAction()
    {
        return true;
    }
}
