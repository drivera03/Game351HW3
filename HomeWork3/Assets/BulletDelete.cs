using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletbye : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;

   

    public float TimeToLive = 5f;

    

    // Update is called once per frame
    void Update()
    {

        Destroy(gameObject, TimeToLive);

    }
}
