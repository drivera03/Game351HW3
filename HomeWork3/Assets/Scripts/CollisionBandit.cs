using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBandit : MonoBehaviour
{
    public Animation deathAnimation;
    //collision detection
    void OnCollisionEnter(Collision collision) {
        GameObject otherObj = collision.gameObject;
        Debug.Log("Collided with: " + otherObj);
        //detects what collided with what
        deathAnimation.Play();

    }

    void OnTriggerEnter(Collider collider) {
        GameObject otherObj = collider.gameObject;
        Debug.Log("Triggered with: " + otherObj);
    }
}
