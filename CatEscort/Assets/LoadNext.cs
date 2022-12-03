using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.TimeZoneInfo;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour
{
    public Animator fadeTransition;
    public float transitionTime = 1f;
    public IEnumerator StartGame()
    {
        fadeTransition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(1);
    }
}
