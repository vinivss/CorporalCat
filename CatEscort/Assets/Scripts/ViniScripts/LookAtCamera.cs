using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    [SerializeField]GameObject CameraFollow;
    // Start is called before the first frame update
    void Start()
    {
        CameraFollow = GameObject.FindGameObjectWithTag("CameraFollow");
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.LookAt(CameraFollow.transform, Vector3.up);
    }
}
