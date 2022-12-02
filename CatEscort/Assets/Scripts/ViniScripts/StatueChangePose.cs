using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueChangePose : MonoBehaviour
{
    public List<GameObject> statuePoses;

    public int index = 0;
    CameraSwitch camSwitch;
    // Start is called before the first frame update
    void Start()
    {
        camSwitch = FindObjectOfType<CameraSwitch>();
    }

    public void ChangePose()
    {
        if(camSwitch.CamIndex == 0)
        {
            statuePoses[index].SetActive(false);
            if(index == statuePoses.Count -1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            statuePoses[index].SetActive(true);
        }
    }

}
