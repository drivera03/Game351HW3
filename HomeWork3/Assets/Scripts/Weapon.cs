using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] private Transform[] bulletSpawnPoints; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            foreach (Transform SpawnPoint in bulletSpawnPoints)
            {
                Instantiate(bulletPrefab, SpawnPoint.position, transform.rotation);
            }
        }
    }
}
