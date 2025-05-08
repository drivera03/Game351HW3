using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchViews : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] cameras; // Array to hold camera prefabs 
    private int currentCamera = 0; 
    void Start()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == currentCamera);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SwitchCamera();
        }
    }
    void SwitchCamera() 
    { 
        // Disable the current camera
        cameras[currentCamera].gameObject.SetActive(false);

        // Increment the camera index, wrapping around if necessary
        currentCamera = (currentCamera + 1) % cameras.Length;

        // Enable the new current camera
        cameras[currentCamera].gameObject.SetActive(true);
    } 
}
