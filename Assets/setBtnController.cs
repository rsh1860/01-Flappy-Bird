using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setBtnController : MonoBehaviour
{
    public Button btnBack;
    public GameObject homeScreenPrefab;


    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.RemoveAllListeners();
        btnBack.onClick.AddListener(BackBtnClick);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void BackBtnClick()
    {
        GameObject currentScreen = Instantiate(homeScreenPrefab);
    }
}
