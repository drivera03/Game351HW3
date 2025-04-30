using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public float kickForce = 500f;
    public float kickRange = 2f;
    public KeyCode kickKey = KeyCode.E;
    public Transform playerTransform; 

    void Update()
    {
        if (Input.GetKeyDown(kickKey))
        {
            Collider[] hitEnemies = Physics.OverlapSphere(playerTransform.position + playerTransform.forward, kickRange);
            foreach (Collider enemy in hitEnemies)
            {
                if (enemy.CompareTag("enemy"))
                {
                    Rigidbody rb = enemy.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        Vector3 kickDirection = playerTransform.forward;
                        rb.AddForce(kickDirection.normalized * kickForce);
                    }
                }
            }
        }
    }
}
