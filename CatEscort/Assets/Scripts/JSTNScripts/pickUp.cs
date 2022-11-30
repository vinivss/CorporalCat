using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public CameraSwitch cam;
    public bool pickedUp = false;
    public int cameraIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && cam.CamIndex == cameraIndex){
            Destroy(gameObject);
            pickedUp = true;
        }
    }
}
