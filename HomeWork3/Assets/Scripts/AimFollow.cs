using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimFollow : MonoBehaviour
{
    [SerializeField] private GameObject TargetObject;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        //Look at different object
        transform.LookAt(TargetObject.transform);

        // Rotate THIS object
        transform.Rotate(0, 0, 0);
    }
}
