using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pencil : MonoBehaviour
{

    public Rigidbody rb;
    public CameraSwitch cam;
    public CheckIfVisible canSee;
    public int camNum;
    public float XForce = 10000f;
    public float YForce = 10000f;
    public float ZForce = 10000f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && cam.CamIndex == camNum)
        {
            rb.AddForce(XForce * Time.deltaTime, YForce * Time.deltaTime, ZForce * Time.deltaTime);
        }
    }
}
