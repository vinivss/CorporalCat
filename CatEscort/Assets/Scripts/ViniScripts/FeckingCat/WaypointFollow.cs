using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    public Waypoints waypoints;

    public float moveSpeed = 5f;

    Transform currentWaypoint;
    [SerializeField] float distanceThreshold;

    [SerializeField] float wallCheckdistance = 1.5f;
    [SerializeField] float floorCheckDistance = 2f;
    //[SerializeField] bool checkFloor = true;
    public bool CatisMoving;

    Vector3 WallHit;
    Vector3 FloorHit;
    bool hitWall;
    bool hitFloor;

    

    // Start is called before the first frame update
    void Start()
    {
        //waypoints = FindObjectOfType<Waypoints>();  
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;

        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove())
        {
            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
            transform.LookAt(currentWaypoint.position);

            if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold && waypoints.GetNextWaypoint(currentWaypoint) != null)
            {
                currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            }
        }

    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * wallCheckdistance, Color.red);

        Debug.DrawRay(transform.position + (transform.TransformDirection(Vector3.forward) * wallCheckdistance), Vector3.down * floorCheckDistance, Color.blue);

        if (hitWall == true)
        {
            Gizmos.color = Color.yellow;
           Gizmos.DrawSphere(WallHit, 0.5f);
        }

        if (hitFloor == true)
        {
            Gizmos.color = Color.white;
            Gizmos.DrawSphere(FloorHit, 0.05f);
            //Debug.Log(FloorHit);
        }
    }

    public bool canMove()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit wallHit, wallCheckdistance))
        {
            hitWall = true;
            WallHit = wallHit.point;
            CatisMoving = false;
            return false;
        }

        if (Physics.Raycast(transform.position + (transform.TransformDirection(Vector3.forward) * wallCheckdistance), transform.TransformDirection(Vector3.down), out RaycastHit floorHit, floorCheckDistance))
        {
            hitFloor = true;
            FloorHit = floorHit.point;
            //Debug.Log(floorHit.point);
            CatisMoving = true;
            return true;
        }
        CatisMoving = false;
        return false;
        
    }
}
