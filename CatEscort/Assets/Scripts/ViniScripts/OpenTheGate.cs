using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheGate : MonoBehaviour
{
    [SerializeField]Animator animator;
    bool isOpen = false;
  
    public void OpenTheDoor()
    {
        isOpen = true;
        animator.SetBool("IsOpen", isOpen);
    }
}
