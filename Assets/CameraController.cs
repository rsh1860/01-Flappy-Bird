using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject bird;



    // Start is called before the first frame update
    void Start()
    {
        this.bird = GameObject.Find("bird0");

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 birdPos = this.bird.transform.position;
        transform.position = new Vector3(
            birdPos.x, 0, -10);
    }

    
}
