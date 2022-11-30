using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTruck : MonoBehaviour
{
    public CheckIfVisible see;
    public pickUp p;

    public Rigidbody rb;
    public float forwardForce = 10000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && p.pickedUp == true && see.isVisible == true){
            rb.AddForce(forwardForce*Time.deltaTime,0,0);
        }
    }

    void move(){
        
    }
}
