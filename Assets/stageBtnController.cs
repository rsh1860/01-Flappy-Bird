using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class stageBtnController : MonoBehaviour
{
    public Button btnBack, btnStage11;
    public GameObject homeScreenPrefab;


    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.RemoveAllListeners();
        btnBack.onClick.AddListener(BackBtnClick);
        btnStage11.onClick.RemoveAllListeners();
        btnStage11.onClick.AddListener(Stage11BtnClick);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BackBtnClick()
    {
        GameObject currentScreen = Instantiate(homeScreenPrefab);
    }

    public void Stage11BtnClick()
    {
        SceneManager.LoadScene("stage11");
    }
}
