using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeMoreCannonStuff : MonoBehaviour
{

    public bool catInside = false;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnCannon()
    {
        Vector3 rotationToAdd = new Vector3(0, 180, 0);
        if (catInside == true)
        {
            transform.Rotate(rotationToAdd);
            catInside = false;
        }
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "cat")
        {
            Debug.Log("hit cat");
            catInside = true;
        }
    }
}
