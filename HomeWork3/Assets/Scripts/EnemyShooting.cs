using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
        
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform[] bulletSpawnPoints; 

    [SerializeField] private float Min_Angle = 0f;
    [SerializeField] private float Max_Angle = 360f;

    private float timePassed =0f;
   void Start()
   {
    foreach(Transform SpawnPoint in bulletSpawnPoints){
    float randomAngle = Random.Range(Min_Angle, Max_Angle);
    SpawnPoint.rotation = Quaternion.Euler(0, 0, randomAngle);
    }
   }
    
    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
            if (timePassed > 30f ){
              

               foreach (Transform SpawnPoint in bulletSpawnPoints)
            {
                Instantiate(bulletPrefab, SpawnPoint.position, SpawnPoint.rotation);
                
            }
            timePassed = 0f;
            }


        
    }
}
