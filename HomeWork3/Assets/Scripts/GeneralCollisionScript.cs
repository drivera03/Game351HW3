using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralCollisionScript : MonoBehaviour
{
    public GameObject Explosion;
    //collision detection
    void OnCollisionEnter(Collision collision) {
        GameObject otherObj = collision.gameObject;
        Debug.Log("Collided with: " + otherObj);
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        //detects what collided with what

    }

    void OnTriggerEnter(Collider collider) {
        GameObject otherObj = collider.gameObject;
        Debug.Log("Triggered with: " + otherObj);
        Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(otherObj);
        Destroy(gameObject);
    }
}
