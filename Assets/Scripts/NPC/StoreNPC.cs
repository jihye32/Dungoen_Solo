using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreNPC : MonoBehaviour
{
    private GameObject player;
    public GameObject storeUseUI;
    public GameObject storeUI;

    private void Start()
    {
        player = GameManager.instance.character;
    }

    private void Update()
    {
        OnUseStore();

        if (storeUseUI.activeInHierarchy && GameManager.instance.characterStats.inputController.inter_action)
        {
            OnStoreText();
        }
    }

    //���� ��� �����ϵ��� [W]���� UI �����ֱ�
    private void OnUseStore()
    {
        if (transform.position.x - player.transform.position.x < 2 && transform.position.x - player.transform.position.x > -2)
        {
            if (!storeUseUI.activeInHierarchy && !storeUI.activeInHierarchy)
            {
                storeUseUI.SetActive(true);
            }
        }
        else
        {
            if(storeUseUI.activeInHierarchy)
            {
                storeUseUI.SetActive(false);
            }
        }
    }

    //����-------------------------------------------------
    //���� �̿��̹Ƿ� ���� �̿� ��ǳ�� ����
    private void OnStoreText()
    {
        OnStoreUI();
        Invoke("OffStoreUI", 2f);
    }

    private void OnStoreUI()
    {
        storeUI.SetActive(true);
        storeUseUI.SetActive(false);
    }

    public void OffStoreUI()
    {
        storeUI.SetActive(false);
    }
}
