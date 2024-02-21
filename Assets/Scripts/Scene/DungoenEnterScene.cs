using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class DungoenEnterScene : MonoBehaviour
{
    private GameObject character;
    public GameObject[] characterPrefabs;
    public GameObject characterPosition;

    private void Awake()
    {
        character = Instantiate(characterPrefabs[0]);
    }

    private void Start()
    {
        character.transform.position = characterPosition.transform.position;
        character.transform.parent = characterPosition.transform;
    }
}
