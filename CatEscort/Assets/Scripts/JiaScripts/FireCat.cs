using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCat : MonoBehaviour
{

    public WaypointFollow wf;
    public OpenSesame os;
    public CameraSwitch cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shootCat()
    {
        if(os.canPass == true && cam.CamIndex == 2) {
            wf.moveSpeed = 100f;
        }
        
    }
}
