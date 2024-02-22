using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
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
        StartCharacterUISetting();
    }

    //캐릭터 UI
    public void StartCharacterUISetting()
    {
        playerName.text = Json.instance.GetName();
        levelText.text = string.Format("Lv. {0}", Json.instance.GetLevel());
        healthText.text = Json.instance.GetHealth().ToString();
        coinText.text = Json.instance.GetCoin().ToString("N0");
        attackText.text = Json.instance.GetAttack().ToString();
        defenseText.text = Json.instance.GetDefense().ToString();
        criticalText.text = Json.instance.GetCritical().ToString();

        levelBar.fillAmount = Json.instance.GetExp()/ Json.instance.GetLevelExp();
        levelExpText.text = Json.instance.GetExp().ToString();
        levelUpExpText.text = Json.instance.GetLevelExp().ToString();
    }

    public void ChageCharacterUISetting()
    {
        healthText.text = Json.instance.GetHealth().ToString();
        attackText.text = Json.instance.GetAttack().ToString();
        defenseText.text = Json.instance.GetDefense().ToString();
        criticalText.text = Json.instance.GetCritical().ToString();
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
