using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilMove : MonoBehaviour
{
    //public CheckIfVisible canSee;
    public Rigidbody rb;
    public float pushForce = 100f;
    Vector3 pointA;
    Vector3 pointB;
    public float Ax = (float)1.22;
    public float Ay = (float)0.64;
    public float Az = (float)-12.44;
    public float Bx = (float)-3.91;

    private void Start()
    {
        pointA = new Vector3(Ax, Ay, Az);
        pointB = new Vector3(Bx, Ay, Az);

    }

    /*private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ball")
        {
            Debug.Log("hit");
        }
    }*/

    /*private void FixedUpdate()
    {
        rb.AddForce(0, 0, pushForce * Time.deltaTime);
    }*/

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("space pressed");
        }*/

        float time = Mathf.PingPong(Time.time * pushForce, 1);
        //Debug.Log(time);
        transform.position = Vector3.Lerp(pointA, pointB, time);
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //transform.Translate(Vector3.up * pushForce * Time.deltaTime);
        //}
        
        //rb.AddForce(pushForce * Time.deltaTime, 0, 0);
        
    }
}
