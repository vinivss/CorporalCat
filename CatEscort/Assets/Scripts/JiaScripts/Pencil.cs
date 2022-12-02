using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pencil : MonoBehaviour
{

    public Rigidbody rb;
    public CameraSwitch cam;
    //public CheckIfVisible canSee;
    //public int camNum;
    public float XForce = 10000f;
    public float YForce = 10000f;
    public float ZForce = 10000f;
    
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {

    }
    public void movePencil()
    {
        //Debug.Log(cam.CamIndex);
        if (cam.CamIndex == 1)
        {
            rb.AddForce(XForce * Time.deltaTime, YForce * Time.deltaTime, ZForce * Time.deltaTime);
        }
    }
}
