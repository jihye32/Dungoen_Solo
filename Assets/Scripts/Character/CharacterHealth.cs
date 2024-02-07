using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public GameObject heartParent;
    private GameObject Heart;
    private GameObject halfHeart;
    private GameObject[] Hearts;

    private void Awake()
    {
        Heart = Resources.Load<GameObject>("Prefabs/Heart");
        halfHeart = Resources.Load<GameObject>("Prefabs/HalfHeart");
    }

    public void MakecharacterHealth(int index)
    {
        Hearts = new GameObject[index];
        for (int i = 0; i < index; i++)
        {
            GameObject newHeart = Instantiate(Heart);
            newHeart.transform.parent = heartParent.transform;
            Hearts[i] = newHeart;
        }
    }
}
