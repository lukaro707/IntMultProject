using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallScript : MonoBehaviour
{
    private GameMangerScript gameMangerScript;
    public AudioSource audioSource;

    private void Start()
    {
        gameMangerScript = GameMangerScript.gameMangerScript;
    }
    private void FixedUpdate()
    {
        if(transform.position.y < -3)
        {
            gameMangerScript.loseLives(1);
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("snowball"))
        {
            Destroy(this.gameObject);
        }
    }
}
