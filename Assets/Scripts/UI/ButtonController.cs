using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    private UIManager uiManager;

    private void Awake()
    {
        uiManager = GetComponent<UIManager>();
    }


    //LoadScene
    public void OnStartButton()
    {
        SceneManager.LoadScene("SelectScene");
    }


    //status UI
    public void OnCharacterStatus()
    {
        if (!uiManager.statusUI.activeInHierarchy)
        {
            uiManager.statusUI.SetActive(true);
        }
    }

    public void OffCharacterStatus()
    {
        uiManager.statusUI.SetActive(false);
    }

    //inventory UI
    public void OnCharacterInventory()
    {
        if (!uiManager.inventoryUI.activeInHierarchy)
        {
            uiManager.inventoryUI.SetActive(true);
        }
    }

    public void OffCharacterInventory()
    {
        uiManager.inventoryUI.SetActive(false);
    }

    //Heart UI
    public void OnHeartUI()
    {
        GameManager.instance.characterHealth.heartParent.SetActive(true);
    }

    public void OffHeartUI()
    {
        GameManager.instance.characterHealth.heartParent.SetActive(false);
    }
}
