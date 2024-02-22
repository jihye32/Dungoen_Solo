using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Header("UI Object")]
    public GameObject statusUI;
    public GameObject inventoryUI;
    public Image levelBar;

    [Header("UI Text")]
    public TMP_Text playerName;
    public TMP_Text levelText;
    public TMP_Text levelExpText;
    public TMP_Text levelUpExpText;
    public TMP_Text coinText;

    public TMP_Text attackText;
    public TMP_Text defenseText;
    public TMP_Text healthText;
    public TMP_Text criticalText;

    [Header("Button Object")]
    public Button statusButton;
    public Button statusCancelButton;
    public Button inventoryButton;
    public Button inventoryCancelButton;
    
    private ButtonController buttonController;

    private void Awake()
    {
        buttonController = GetComponent<ButtonController>();
    }

    private void Start()
    {
        buttonAddListener();
    }

    //캐릭터 UI
    public void StartCharacterUISetting(PlayerData playerData)
    {
        playerName.text = playerData.name;
        levelText.text = string.Format("Lv. {0}", playerData.level);
        healthText.text = playerData.health.ToString();
        coinText.text = playerData.coin.ToString("N0");
        attackText.text = playerData.attack.ToString();
        defenseText.text = playerData.defense.ToString();
        criticalText.text = playerData.critical.ToString();

        levelBar.fillAmount = playerData.exp / playerData.levelexp;
        levelExpText.text = playerData.exp.ToString();
        levelUpExpText.text = playerData.levelexp.ToString();
    }

    public void ChageCharacterUISetting()
    {
        healthText.text = GameManager.instance.health.ToString();
        attackText.text = GameManager.instance.attack.ToString();
        defenseText.text = GameManager.instance.defense.ToString();
        criticalText.text = GameManager.instance.critical.ToString();
    }

    //버튼 UI
    private void buttonAddListener()
    {
        //statusUI
        statusButton.onClick.AddListener(() => buttonController.OnCharacterStatus());
        statusButton.onClick.AddListener(() => buttonController.OffHeartUI());

        statusCancelButton.onClick.AddListener(() => buttonController.OffCharacterStatus());
        statusCancelButton.onClick.AddListener(() => buttonController.OnHeartUI());

        //inventoryUI
        inventoryButton.onClick.AddListener(() => buttonController.OnCharacterInventory());

        inventoryCancelButton.onClick.AddListener(() => buttonController.OffCharacterInventory()); //AddListener의 단점... button 이름 잘못 설정하면 꼬임..
    }
}
