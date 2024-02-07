using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("UI")]
    public GameObject statusButton;
    public GameObject inventoryButton;
    public GameObject statusUI;




    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }
}
