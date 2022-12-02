using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public CameraSwitch cam;
    public bool pickedUp = false;
    public int cameraIndex;
    public pickUp p;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && cam.CamIndex == cameraIndex && p.pickedUp == true){
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}
