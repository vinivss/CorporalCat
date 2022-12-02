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
           Instantiate(pencilPrefab, new Vector3(0,0,0), Quaternion.identity);
           WaypointFollow waypointFollow = pencilPrefab.GetComponent<WaypointFollow>();
            waypointFollow.waypoints =  intendedFollow;
            waypointFollow.enabled = true;
        }
    }


}
