using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Object itemData;

    private void Start()
    {
        itemData = Resources.Load("Sword");
    }
}
