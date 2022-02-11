using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject paddlePrefab;

    private GameObject p1Paddle;
    private GameObject p2Paddle;

    // Start is called before the first frame update
    void Start()
    {
        p1Paddle = Instantiate(paddlePrefab, new Vector3(-10, 0), Quaternion.identity);
        p2Paddle = Instantiate(paddlePrefab, new Vector3(10, 0), Quaternion.Euler(0, 0, 180));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
