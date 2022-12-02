using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheTapes : MonoBehaviour
{
    public CameraSwitch cameraSwitch;
    public List<GameObject> Tapes;
    // Start is called before the first frame update
    void Start()
    {
        cameraSwitch = FindObjectOfType<CameraSwitch>();
    }
    public void RollThatShit()
    {
        if(cameraSwitch.CamIndex == 2)
        foreach(var Tape in Tapes)
        {
           WaypointFollow wp = Tape.GetComponent<WaypointFollow>();
            wp.enabled = true;
        }
    }
}
