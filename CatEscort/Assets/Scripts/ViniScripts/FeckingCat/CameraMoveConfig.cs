using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraMoveConfig : MonoBehaviour
{
    [SerializeField] float backAngle = 65f;
    [SerializeField] float sideAngle = 155f;
    [SerializeField] Transform maintransform;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void LateUpdate()
    {
        Vector3 camForward = new Vector3(Camera.main.transform.forward.x, 0f, Camera.main.transform.forward.z);
        float signedAngle = Vector3.SignedAngle(maintransform.forward, camForward, Vector3.up);
        Vector2 animatonDirection = new Vector2(0f, -1f);
        float angle = Mathf.Abs(signedAngle);

        if(signedAngle < 0)
        {
            animatonDirection = new Vector2(-1f, 0f);
        }

        else if(angle < backAngle)
        {
            //back animation
            animatonDirection = new Vector2(0f, 1f);
        }

        else if(angle < sideAngle)
        {
            animatonDirection = new Vector2(1f, 0f);
        }

        else
        {
            animatonDirection = new Vector2(0f, -1f);
        }
        animator.SetFloat("XrelSpeed", animatonDirection.x);
        animator.SetFloat("YrelSpeed", animatonDirection.y);
    }
}
