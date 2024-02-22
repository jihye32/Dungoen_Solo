using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterNPC : MonoBehaviour
{
    private GameObject player;
    public GameObject enterUI; //[W]
    public GameObject dungoenEnterUI; //말풍선
    public Button enterButton;
    public Button exitButton;

    private void Awake()
    {
        player = GameManager.instance.character;
    }

    private void Start()
    {
        enterButton.onClick.AddListener(() => OffDungoenEnterUI());
        enterButton.onClick.AddListener(() => OnGoDungoen());

        exitButton.onClick.AddListener(() => OffDungoenEnterUI());
    }

    private void Update()
    {
        OnEnterText();

        if (enterUI.activeInHierarchy && GameManager.instance.characterStats.inputController.inter_action)
        {
            OnDungoenEnterUI();
        }
    }

    //던전--------------------------------------------------
    //[W] UI SetActive
    private void OnEnterText()
    {
        if (transform.position.x - player.transform.position.x < 2 && transform.position.x - player.transform.position.x > -2)
        {
            if (!enterUI.activeInHierarchy && !dungoenEnterUI.activeInHierarchy)
            {
                enterUI.SetActive(true);
            }
        }
        else
        {
            if (enterUI.activeInHierarchy)
            {
                enterUI.SetActive(false);
            }
        }
    }

    //말풍선UI
    private void OnDungoenEnterUI()
    {
        dungoenEnterUI.SetActive(true);
        enterUI.SetActive(false);
    }

    public void OffDungoenEnterUI()
    {
        dungoenEnterUI.SetActive(false);
    }

    //버튼선택UI
    public void OnGoDungoen()
    {
        SceneManager.LoadScene("DungoenScene");
    }
}
