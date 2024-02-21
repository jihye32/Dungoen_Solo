using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public AttackStatusData statusData;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EnterDungoen")
        {
            GameManager.instance.character.transform.position = new Vector3(31.5f, -3.5f, 0);
            GameManager.instance.camera.transform.position = new Vector3(40, 0, -10);
        }
        else if (collision.gameObject.tag == "GoMain")
        {
            GameManager.instance.character.transform.position = new Vector3(8.5f, -3.5f, 0);
            GameManager.instance.camera.transform.position = new Vector3(0, 0, -10);
        }
    }
}
