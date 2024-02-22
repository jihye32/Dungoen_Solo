using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    private UIController UIcontroller;

    private void Awake()
    {
        UIcontroller = GetComponent<UIController>();
    }


    //LoadScene
    public void OnStartButton()
    {
        SceneManager.LoadScene("SelectScene");
    }


    //status UI
    public void OnCharacterStatus()
    {
        if (!UIcontroller.statusUI.activeInHierarchy)
        {
            UIcontroller.statusUI.SetActive(true);
        }
    }

    public void OffCharacterStatus()
    {
        UIcontroller.statusUI.SetActive(false);
    }

    //inventory UI
    public void OnCharacterInventory()
    {
        if (!UIcontroller.inventoryUI.activeInHierarchy)
        {
            UIcontroller.inventoryUI.SetActive(true);
        }
    }

    public void OffCharacterInventory()
    {
        UIcontroller.inventoryUI.SetActive(false);
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
