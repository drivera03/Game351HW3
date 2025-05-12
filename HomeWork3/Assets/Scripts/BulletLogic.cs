using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bull : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Die();
            Destroy(gameObject); // Destroy the bullet
        }
    }
}
