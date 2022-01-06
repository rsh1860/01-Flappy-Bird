using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageGameManager : MonoBehaviour
{
    public GameObject stageScreenPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject currentScreen = Instantiate(stageScreenPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
