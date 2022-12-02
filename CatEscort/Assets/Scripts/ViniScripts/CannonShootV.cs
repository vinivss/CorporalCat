using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShootV : MonoBehaviour
{
    CameraSwitch switchCam;

    bool isLoaded = false;
    StatueChangePose changePose;
    [SerializeField] GameObject Cannonball;
    
    // Start is called before the first frame update
    void Start()
    {
        //changePose = 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cannonball")
        {
            isLoaded = true;
            Animator anim = other.GetComponent<Animator>();

            anim.SetBool("Drop", false);
            anim.Play("IdlePose", -1, 0f);
        }

        if(other.tag == "Torch" && isLoaded == true)
        {
            isLoaded = false;
            Animator anim = other.GetComponent<Animator>();

            anim.SetBool("Drop", false);
            anim.Play("IdlePose", -1, 0f);
            
        }
    }
}
