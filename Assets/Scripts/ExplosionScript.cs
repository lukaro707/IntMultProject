using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.collider.gameObject.tag;
        if (tag.Equals("snowball"))
        {
            Destroy(collision.collider.gameObject);
        }
        if (tag.Equals("bomb"))
        {
            Destroy(collision.collider.gameObject);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        string tag = collision.collider.gameObject.tag;
        if (tag.Equals("snowball"))
        {
            Destroy(collision.collider.gameObject);
        }
        if (tag.Equals("bomb"))
        {
            Destroy(collision.collider.gameObject);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        string tag = collision.collider.gameObject.tag;
        if (tag.Equals("snowball"))
        {
            Destroy(collision.collider.gameObject);
        }
        if (tag.Equals("bomb"))
        {
            Destroy(collision.collider.gameObject);
        }
    }
}
