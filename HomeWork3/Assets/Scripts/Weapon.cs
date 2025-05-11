using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] private Transform[] bulletSpawnPoints; 

    [SerializeField] private float fireRate = 0.2f; //orginally wasn't here

    private float nextFireTime = 0f; //fire time in between 
    
    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.F) && Time.time >= nextFireTime){
                nextFireTime = Time.time +fireRate;

               foreach (Transform SpawnPoint in bulletSpawnPoints)
            {
                Instantiate(bulletPrefab, SpawnPoint.position, SpawnPoint.rotation);// transform.rotation);
            }

            }


        // this is the orginal code in case the game breaks
        // if (Input.GetKey(KeyCode.F))
        // {
        //     foreach (Transform SpawnPoint in bulletSpawnPoints)
        //     {
        //         Instantiate(bulletPrefab, SpawnPoint.position, SpawnPoint.rotation);// transform.rotation);
        //     }
        // }
    }
}
