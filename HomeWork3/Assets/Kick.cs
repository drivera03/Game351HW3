using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public float kickForce = 500f;
    public float kickRadius = 0.5f;
    public string targetTag = "enemy";
    public KeyCode kickKey = KeyCode.Space;
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
            int randomKick = Random.Range(1, 4); 
            animator.SetTrigger("Kick" + randomKick);
        }
    }

    private void OnTriggerEnter(Collider other)    
    {
                if (other.CompareTag(targetTag))
        {
            Rigidbody rb = other.attachedRigidbody;

            if (rb != null)
            {
                // Calculate direction from foot to target
                Vector3 kickDirection = (other.transform.position - transform.position).normalized;
                rb.AddForce(kickDirection * kickForce);
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