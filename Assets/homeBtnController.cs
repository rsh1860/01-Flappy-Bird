using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class homeBtnController : MonoBehaviour
{
    public Button btnStart, btnShop, btnSetting;
    public GameObject shopScreenPrefab, settingScreenPrefab;

    public Dictionary<string, GameObject> pooledObjects;

    public void Start()
    {
        btnStart.onClick.RemoveAllListeners();
        btnStart.onClick.AddListener(GameStartBtnClick);

        btnShop.onClick.RemoveAllListeners();
        btnShop.onClick.AddListener(ShopBtnClick);

        btnSetting.onClick.RemoveAllListeners();
        btnSetting.onClick.AddListener(SettingBtnClick);

        pooledObjects = new Dictionary<string, GameObject>();

        var tmp = Instantiate(shopScreenPrefab);
        var tmp1 = Instantiate(settingScreenPrefab);
        tmp.SetActive(false);
        tmp1.SetActive(false);

        pooledObjects.Add("Shop", tmp);
        pooledObjects.Add("Setting", tmp1);

    }


    public void GameStartBtnClick()
    {
        SceneManager.LoadScene("stageScene");

    }

    public void ShopBtnClick()
    {
        if (!pooledObjects["Shop"].activeInHierarchy)
            pooledObjects["Shop"].SetActive(true);
    }

    public void SettingBtnClick()
    {
        if (!pooledObjects["Setting"].activeInHierarchy)
            pooledObjects["Setting"].SetActive(true);
    }
    
}
