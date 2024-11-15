using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{
    public GameObject snowBallPrefab;
    public GameObject bombPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnBall", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnBall()
    {
        GameObject spawn;
        if(Random.value <= 0.2)
        {
            spawn = bombPrefab;
        } else
        {
            spawn = snowBallPrefab;
        }
        Instantiate(spawn, new Vector3(Random.Range(transform.position.x - transform.lossyScale.x/2 , transform.position.x + transform.lossyScale.x / 2), transform.position.y, transform.position.z), Quaternion.identity);
    }
}
