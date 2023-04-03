using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject menuManagerPrefab;

    void Start()
    {
        Instantiate(menuManagerPrefab);
    }
}
