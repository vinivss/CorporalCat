using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public Rigidbody rb;
    //public bool loaded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Debug.Log(loaded);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(loaded);
        }*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "cannon")
        {
            Destroy(this.gameObject);
            //loaded = true;
            //Debug.Log(loaded);
        }

        if (collision.gameObject.tag == "wall")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
