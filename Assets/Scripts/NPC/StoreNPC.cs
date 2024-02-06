using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreNPC : MonoBehaviour
{
    private GameObject player;
    private GameObject storeUseUI;
    public GameObject storeUI;
    private NPCUI npuUI;
    

    private void Start()
    {
        
        player = GameManager.instance.player;
        npuUI = GetComponentInParent<NPCUI>();
    }

    private void Update()
    {
        OnUseStore();
        OnStoreUI();
    }

    private void OnUseStore()
    {
        if (transform.position.x - player.transform.position.x < 1 && transform.position.x - player.transform.position.x > -1)
        {
            if(storeUseUI == null)
            {
                storeUseUI = npuUI.useStoreUI;
                npuUI.useStoreUI.SetActive(true);
            }
        }
        else if(storeUseUI != null)
        {
            storeUseUI = null;
            npuUI.useStoreUI.SetActive(false);
        }
    }

    private void OnStoreUI()
    {
        if(storeUseUI != null && GameManager.instance.player_interaction)
        {
            storeUI.SetActive(true);
        }
    }

    public void OffStoreUI()
    {
        storeUI.SetActive(false);
    }
}
