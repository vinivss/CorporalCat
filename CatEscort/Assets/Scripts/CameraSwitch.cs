using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class CameraSwitch : MonoBehaviour
{
    Controls Input;

    [Tooltip("These are the cameras to cycle in between")]
    [Header("Cameras")]
    public List<CinemachineVirtualCamera> Cameras = new List<CinemachineVirtualCamera>();

    private void Awake()
    {
        Input = new Controls();
        GetAllCameras();
        Input.Actions.ActionButton.performed += ctx =>
        {

        };
        Input.Actions.LeftButton.performed += ctx =>
        {
            ChangeToNextCam();
        };
        Input.Actions.RightButton.performed += ctx =>
        {
            ChangeToPrevCam();
        };
        
    }

    private void GetAllCameras()
    {
        throw new NotImplementedException();
    }

    private void ChangeToNextCam()
    {
        throw new NotImplementedException();
    }

    private void ChangeToPrevCam()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        Input.Enable();
    }

    private void OnDisable()
    {
        Input.Disable();  
    }
}
