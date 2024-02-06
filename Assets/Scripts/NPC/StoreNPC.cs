using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreNPC : MonoBehaviour
{
    private GameObject player;
    private GameObject storeUseUI;
    private NPCUI npuUI;
    

    private void Start()
    {
        player = GameManager.instance.player;
        npuUI = GetComponentInParent<NPCUI>();
        storeUseUI = npuUI.useStoreUI;
    }

    private void Update()
    {
        OnUseStore();
    }

    private void OnUseStore()
    {
        if(transform.position.x - player.transform.position.x < 1 && transform.position.x - player.transform.position.x > -1)
        {
            storeUseUI.SetActive(true);
        }
        else storeUseUI.SetActive(false);
    }
}
