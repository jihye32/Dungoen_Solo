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
            GameManager.instance.SaveCharacterStats();
            SceneManager.LoadScene("DungoenEnterScene");
        }
        else if (collision.gameObject.tag == "GoMain")
        {
            GameManager.instance.SaveCharacterStats();
            SceneManager.LoadScene("MainScene");
        }
    }

    
}
