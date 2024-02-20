using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EnterDungoen")
        {
            SceneManager.LoadScene("DungoenEnterScene");
        }
        else if (collision.gameObject.tag == "GoMain")
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
