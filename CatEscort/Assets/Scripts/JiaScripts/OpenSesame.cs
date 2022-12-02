using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSesame : MonoBehaviour
{

    public GameObject invisWall;
    public GameObject invisFloor;
    public bool canPass = false;
    public turnCannon tc;
    public CameraSwitch cam;
    //public CameraSwitch cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openUp()
    {
        if (tc.isTurned == true && cam.CamIndex == 2)
        {
            Destroy(invisWall);
            invisFloor.gameObject.SetActive(true);
            canPass = true;
        }
        
    }
}
