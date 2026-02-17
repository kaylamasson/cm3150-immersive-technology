using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMD_Manager : MonoBehaviour
{
    [SerializeField] GameObject xrPlayer;
    [SerializeField] GameObject fpsPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Using device:" + XRSettings.loadedDeviceName);

        // if XR device is connected to system 
        // use XR player rather than test FPS 

        if(XRSettings.isDeviceActive || XRSettings.loadedDeviceName == "OpenXR Display"){
            Debug.Log("Using device XR Player with HMD:" + XRSettings.loadedDeviceName);
            fpsPlayer.SetActive(false);
            xrPlayer.SetActive(true);
        }
        else {
            Debug.Log("No HMD detected, using FPS player");
            xrPlayer.SetActive(false); 
            fpsPlayer.SetActive(true); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
