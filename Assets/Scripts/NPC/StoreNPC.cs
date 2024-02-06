using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreNPC : MonoBehaviour
{
    private GameObject player;
    

    private void Awake()
    {
        player = GameManager.instance.player;
    }

    private void OnUseStore()
    {
        if(transform.position.x - player.transform.position.x < 1 && transform.position.x - player.transform.position.x > -1)
        {

        }
    }
}
