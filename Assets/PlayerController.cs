using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid;
    public float birdJump = 5f;

    public GameObject gameFailPrefab, gameClearPrefab, coin;

    public Dictionary<string, GameObject> pooledObjects;

    // Start is called before the first frame update
    void Start()
    {
        pooledObjects = new Dictionary<string, GameObject>();
        var tmp0 = Instantiate(gameFailPrefab);
        var tmp1 = Instantiate(gameClearPrefab);
        tmp0.SetActive(false);
        tmp1.SetActive(false);

        pooledObjects.Add("Fail", tmp0);
        pooledObjects.Add("Clear", tmp1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(1, birdJump, 0);
            transform.rotation = Quaternion.Euler(0, 0, 3f);
        }

        transform.Rotate(0, 0, -0.1f);


        
    }

    /*
    void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "obstacles")
        {
            if (!pooledObjects["Fail"].activeInHierarchy)
                pooledObjects["Fail"].SetActive(true);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            if (!pooledObjects["Clear"].activeInHierarchy)
                pooledObjects["Clear"].SetActive(true);

            Destroy(coin);
        }    
    }
    */
}

    
