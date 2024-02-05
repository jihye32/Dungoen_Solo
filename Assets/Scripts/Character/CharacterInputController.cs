using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInputController : CharacterController
{
    private Vector3 lookRight = new Vector3(-1, 1, 1);
    private Vector3 lookLeft = new Vector3(1, 1, 1);

    public void OnMove(InputValue moveInput)
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = lookRight;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = lookLeft;
        }
        Vector2 direction = moveInput.Get<Vector2>().normalized;
        moveMent(direction);
    }

    public void OnAction(InputValue value)
    {
        if(value.isPressed == true)
        {
            interAction();
        }
    }
}
