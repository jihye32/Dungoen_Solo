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
        direction = direction * GameManager.instance.playerData.speed; //���������� �������� �ʵ��� �� ���̱� ������ �������
        rigidBody.velocity = direction;
    }

    protected bool interAction()
    {
        return true;
    }
}
