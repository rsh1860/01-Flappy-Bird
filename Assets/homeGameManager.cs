using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeGameManager : MonoBehaviour
{
    public GameObject homeScreenPrefab;
    public GameObject settingScreenPrefab;
    public GameObject shopScreenPrefab;

    void Start()
    {
        GameObject currentScreen = Instantiate(homeScreenPrefab);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
