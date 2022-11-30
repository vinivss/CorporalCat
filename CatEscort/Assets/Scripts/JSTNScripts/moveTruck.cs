using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTruck : MonoBehaviour
{
    public CameraSwitch cam;
    public CheckIfVisible see;
    public pickUp p;

    public Rigidbody rb;
    public float forwardForce = 10000f;
    public int cameraIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cam.CamIndex);
        if(Input.GetKeyDown(KeyCode.Space) && p.pickedUp == true && cam.CamIndex == cameraIndex){
            rb.AddForce(forwardForce*Time.deltaTime,0,0);
        }
    }

    void move(){
        
    }
}
