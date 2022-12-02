using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Waypoints : MonoBehaviour
{
    [Range(0f, 5f)]
    [Header("Editor")]
    [Tooltip("This is the radius of the waypoint Spheres")]
    [SerializeField] float waypointRadius;
    [SerializeField] Animator Catanim;
    [Tooltip("Will this path loop around")]
    public bool LoopingPath;
    public Animator fadeTransition;
    private void OnDrawGizmos()
    {
        foreach(Transform t in transform)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(t.position, waypointRadius);  
        }

        Gizmos.color = Color.red;
        for(int i= 0; i < transform.childCount - 1; i++)
        {
            Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(i + 1).position);
        }

        if(LoopingPath == true)
        {
            Gizmos.DrawLine(transform.GetChild(transform.childCount - 1).position, transform.GetChild(0).position);
        }
    }

    public Transform GetNextWaypoint(Transform currentWaypoint)
    {
        if (currentWaypoint == null)
        {
            return transform.GetChild(0);
        }

        if(currentWaypoint.GetSiblingIndex() < transform.childCount - 1)
        {
            return transform.GetChild(currentWaypoint.GetSiblingIndex() + 1);
        }

        else if(LoopingPath)
        {
            return transform.GetChild(0);
        }
        Catanim.SetBool("Win", true);
        
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex + 1));
        //Catanim.Play("Win", -1, 0f);
        return null;
    }
    IEnumerator NextLevel(int levelIndex)
    {
        fadeTransition.SetTrigger("Start");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(levelIndex);
    }
}
