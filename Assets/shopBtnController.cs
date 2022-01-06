using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopBtnController : MonoBehaviour
{
    [SerializeField] public Button btnBack, btnEgg;
    public GameObject homeScreenPrefab;

    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.RemoveAllListeners();
        btnBack.onClick.AddListener(BackBtnClick);
        btnEgg.onClick.RemoveAllListeners();
        btnEgg.onClick.AddListener(EggBtnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackBtnClick()
    {
        GameObject currentScreen = Instantiate(homeScreenPrefab);
    }

    public void EggBtnClick()
    {
        
    }
}
