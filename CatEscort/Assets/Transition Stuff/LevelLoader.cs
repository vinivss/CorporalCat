using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator fadeTransition;
    public float transitionTime = 1f;


    // Update is called once per frame


    public void LoadNextLevel()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex + 1));
        
    }
    public IEnumerator NextLevel(int levelIndex)
    {
        fadeTransition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
    
}
