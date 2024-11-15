using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public GameObject explosion;
    private GameMangerScript gameMangerScript;
    public AudioSource audioSource;

    private void Start()
    {
        gameMangerScript = GameMangerScript.gameMangerScript;
    }

    private void FixedUpdate()
    {
        if (transform.position.y < -3)
        {
            gameMangerScript.loseLives(2);
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag.Equals("snowball"))
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
            explosion.SetActive(true);
            audioSource.Play();
            Invoke("DestroyBomb", 0.5f);
        }

    }

    private void DestroyBomb()
    {
        Destroy(explosion);
        Destroy(gameObject);
    }
}
