using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    //InputData
    protected void moveMent(Vector2 direction)
    {
        direction = direction * GameManager.instance.playerData.speed; //던전에서는 움직이지 않도록 할 것이기 때문에 상관없음
        rigidBody.velocity = direction;
    }

    protected bool interAction()
    {
        return true;
    }
}
