using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    [SerializeField] private float LaunchForce = 3000f;

    public float TimeToLive = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.forward * LaunchForce;
        
    }

    // Update is called once per frame
    void Update()
    {

        Destroy(gameObject, TimeToLive);

    }
}
