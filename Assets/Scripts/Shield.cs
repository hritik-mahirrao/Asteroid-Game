using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject);
        }
    }
}
