using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{
    public GameObject snowBallPrefab;
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
        Instantiate(snowBallPrefab, new Vector3(Random.Range(transform.position.x - transform.lossyScale.x/2 , transform.position.x + transform.lossyScale.x / 2), transform.position.y, transform.position.z), Quaternion.identity);
    }
}
