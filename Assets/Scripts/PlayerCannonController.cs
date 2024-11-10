using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCannonController : MonoBehaviour
{
    public GameObject snowBallPrefab;
    public float snowBallSpawnOffset;
    public float ballFiringForceMult;
    public float accelerationMult = 50;
    public float maxSpeed = 3;
    Rigidbody body;
    public 
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 snowBallSpawnLocation = transform.position;
            snowBallSpawnLocation.z += snowBallSpawnOffset;
            GameObject firedSnowball = Instantiate(snowBallPrefab, snowBallSpawnLocation, Quaternion.Euler(0, 0, 0));
            firedSnowball.GetComponent<Rigidbody>().AddForce(Vector3.forward * ballFiringForceMult, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            body.AddForce(Vector3.left * accelerationMult, ForceMode.Acceleration);
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            body.AddForce(Vector3.right * accelerationMult, ForceMode.Acceleration);
        }
        Mathf.Clamp(body.velocity.magnitude, 0, maxSpeed);
    }
}
