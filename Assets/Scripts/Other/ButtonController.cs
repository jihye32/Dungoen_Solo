using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    //수정 필요!
    //intro, select Scene
    public void OnStartButton()
    {
        SceneManager.LoadScene("SelectScene");
    }

    public void OnMainSceneButton()
    {
        SceneManager.LoadScene("MainScene");
    }


    //status UI
    public void OnClickCharacterStatus()
    {
        GameManager.instance.statusUI.SetActive(true);
        GameManager.instance.statusButton.SetActive(false);
        GameManager.instance.inventoryButton.SetActive(false);
        GameManager.instance.characterHealth.heartParent.SetActive(false);
    }

    public void OffClickCharacterStatus()
    {
        GameManager.instance.statusUI.SetActive(false);
        GameManager.instance.statusButton.SetActive(true);
        GameManager.instance.inventoryButton.SetActive(true);
        GameManager.instance.characterHealth.heartParent.SetActive(true);
    }

    //inventory UI
    public void OnClickCharacterInventory()
    {
        GameManager.instance.inventoryUI.SetActive(true);
        GameManager.instance.statusButton.SetActive(false);
        GameManager.instance.inventoryButton.SetActive(false);
    }

    public void OffClickCharacterInventory()
    {
        GameManager.instance.inventoryUI.SetActive(false);
        GameManager.instance.statusButton.SetActive(true);
        GameManager.instance.inventoryButton.SetActive(true);
    }
}
