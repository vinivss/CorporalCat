using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{

    public GameObject bullet_emitter;
    public GameObject bullet;
    public float forward_Force;
    public CameraSwitch cam;
    public bool loaded = false;
    public bool turn = false;

    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        //Debug.Log(cam.CamIndex);
 
    }

    public void fire()
    {
        if (cam.CamIndex == 3 && loaded == true)
        {
            GameObject temporary_Bullet;
            temporary_Bullet = Instantiate(bullet, bullet_emitter.transform.position, bullet_emitter.transform.rotation) as GameObject;
            Rigidbody temp_Rigidbody;
            temp_Rigidbody = temporary_Bullet.GetComponent<Rigidbody>();
            temp_Rigidbody.AddForce(transform.forward * forward_Force);
            loaded = false;
            turn = true;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            loaded = true;
        }
    }

}
