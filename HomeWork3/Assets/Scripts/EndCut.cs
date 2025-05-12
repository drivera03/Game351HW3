using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.Playables;

public class EndCut : MonoBehaviour
{
    public Camera[] cameras; // Array to hold references to the cameras
    private int currentCameraIndex = 0; // Index of the currently active camera

    void Start()
    {
        // Ensure only the first camera is enabled at the start
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == currentCameraIndex);
        }

    }

    void Update()
    {
        // Check for input to switch cameras (e.g., pressing the 'C' key)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        // Disable the current camera
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Increment the camera index, wrapping around if necessary
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

        // Enable the new current camera
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }
}

