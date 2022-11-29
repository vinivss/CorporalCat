using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    [SerializeField]Waypoints waypoints;

    [SerializeField] float moveSpeed = 5f;

    Transform currentWaypoint;
    [SerializeField] float distanceThreshold;

    public bool startMovement;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = FindObjectOfType<Waypoints>();  
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;

        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
    }

    // Update is called once per frame
    void Update()
    {
        if (startMovement)
        {
            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold && waypoints.GetNextWaypoint(currentWaypoint) != null)
            {
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            }
        }
    }
}
