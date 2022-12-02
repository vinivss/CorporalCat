using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperAirplane : MonoBehaviour
{

    public Rigidbody airplane;
    public float fwdForce = 10.0f;
    public CameraSwitch cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cam.CamIndex == 2)
        {
            airplane = GetComponent<Rigidbody>();
            airplane.AddForce(transform.forward * fwdForce);
        }
    }
}
