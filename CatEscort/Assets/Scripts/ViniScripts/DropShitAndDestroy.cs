using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropShitAndDestroy : MonoBehaviour
{
    public StatueChangePose Statues;
    [SerializeField] Animator CannonballAnim;
    [SerializeField] Animator TorchAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pencil")
        {
            switch(Statues.index)
            {
                case 0:
                    DestroyImmediate(other.gameObject);
                    break;
                case 1:
                    CannonballAnim.SetBool("Drop", true);
                    DestroyImmediate(other.gameObject);
                    break;
                case 2:
                    TorchAnimator.SetBool("Drop", true);
                    DestroyImmediate(other.gameObject);
                    break;
            }
        }
    }
}
