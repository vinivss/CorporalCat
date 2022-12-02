using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DestroyBarricade : MonoBehaviour
{
    [SerializeField]List<GameObject> Barricades = new List<GameObject>();
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == ("Cannonball"))
        {
            foreach(var n in Barricades)
            {
                Destroy(n.gameObject);
            }
            Destroy(other.gameObject);
        }
    }
}
