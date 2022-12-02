using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnCannon : MonoBehaviour
{
    public FireBullet fb;
    public CameraSwitch cam;
    public bool isTurned = false;
    /*void Start()
    {
        fb = GameObject.FindGameObjectWithTag("tagA").GetComponent<FireBullet>();
        
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
    public void rotate180()
    {
        Vector3 rotationToAdd = new Vector3(0, 180, 0);
        if (cam.CamIndex == 3 && fb.loaded == false && fb.turn == true)
        {
            
            transform.Rotate(rotationToAdd);
            fb.turn = false;
            isTurned = true;
        }
        
    }
}
