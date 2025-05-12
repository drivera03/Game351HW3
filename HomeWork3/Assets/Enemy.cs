using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator animator;
    private bool isDead = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Die()
    {
        if (isDead) return;

        isDead = true;
        animator.SetTrigger("Death");
        GetComponent<Collider>().enabled = false; // Turn off collider
        Destroy(gameObject, 2f); // Destroy after animation
    }
}