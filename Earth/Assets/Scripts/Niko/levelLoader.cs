using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
    public Animator animator;
    public int waitTime = 1;
    public int _levelIndex;

    private void Start()
    {
        _levelIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void loadGameSelection()
    {
        _levelIndex = 0;
        StartCoroutine(LoadScene(0));
    }

    public void loadSamunTutorial()
    {
        _levelIndex = 1;
        StartCoroutine(LoadScene(1));
    }

    public void loadSamunScene()
    {
        _levelIndex = 2;
        StartCoroutine(LoadScene(2));
    }


    public void loadNikonScene()
    {
        _levelIndex = 3;
        StartCoroutine(LoadScene(3));
    }


    IEnumerator LoadScene(int levelIndex)
    {
        animator.SetTrigger("Start");

        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(levelIndex);

        animator.SetTrigger("End");
    }

}
