using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTnt : MonoBehaviour
{
    public GameObject HitAnimation;

    public GameObject Debre;
    // Start is called before the first frame update
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
        Instantiate(HitAnimation, transform.position, transform.rotation);
        Instantiate(Debre, transform.position, transform.rotation);
        Destroy(otherObj);
        Destroy(gameObject);
    }
}
