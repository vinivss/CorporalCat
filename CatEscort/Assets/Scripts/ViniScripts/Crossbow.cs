using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    CameraSwitch cameraSwitch;
    [SerializeField] GameObject pencilPrefab;
    [SerializeField] Waypoints intendedFollow;
    // Start is called before the first frame update
    void Start()
    {
        cameraSwitch = FindObjectOfType<CameraSwitch>();   
    }

   public void ShootCrossbow()
    {
        if(cameraSwitch.CamIndex == 1)
        {
           Instantiate(pencilPrefab);
           WaypointFollow waypointFollow = pencilPrefab.GetComponent<WaypointFollow>();
            waypointFollow.waypoints =  intendedFollow;
            waypointFollow.enabled = true;
        }
    }


}
