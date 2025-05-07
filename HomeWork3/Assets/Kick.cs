using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public float kickForce = 500f;
    public float kickRadius = 0.5f;
    public KeyCode kickKey = KeyCode.E;
    public Animator animator;

    void Awake()
    {
        if (animator == null)
        {
            animator = GetComponentInChildren<Animator>();
        }

    }   
    void Update()
    {
        if (Input.GetKeyDown(kickKey))
        {
            // Trigger a random kick animation
            int randomKick = Random.Range(1, 4); // returns 1, 2, or 3
            animator.SetTrigger("Kick" + randomKick);
        }
    }

    // This method is called from an Animation Event at the peak of the kick
    public void PerformKick()
    {
        // Kick origin is slightly in front of the player
        Vector3 kickOrigin = transform.position + transform.forward * 1.0f; // 1.0f is kick distance
        float kickRadius = 0.5f; // Same as before

        Collider[] hitEnemies = Physics.OverlapSphere(kickOrigin, kickRadius);
        foreach (Collider enemy in hitEnemies)
        {
            if (enemy.CompareTag("enemy"))
            {
                Rigidbody rb = enemy.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    Vector3 kickDirection = (enemy.transform.position - transform.position).normalized;
                    rb.AddForce(kickDirection * kickForce);
                }
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Vector3 kickOrigin = transform.position + transform.forward * 1.0f;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(kickOrigin, 0.5f);
    }
}