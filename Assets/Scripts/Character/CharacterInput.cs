using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public AttackStatusData statusData;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
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
