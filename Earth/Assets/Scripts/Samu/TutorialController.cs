using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class TutorialController : MonoBehaviour
{
    [SerializeField] private List<GameObject> tutorialScreen = new List<GameObject>();
    [SerializeField] private Button playButton;

    public int index;

    private void Awake()
    {
        for (int i = 0; i < tutorialScreen.Count; i++)
        {
            tutorialScreen[i].SetActive(false);
        }
        tutorialScreen[0].SetActive(true);
        playButton.gameObject.SetActive(false);
    }

    private void Start()
    {
        StartCoroutine(screenTimer());
    }

    private void NextScreen()
    {
        if (index < 3)
        {
            index++;
        }
        else
        {
            index = 0;
        }
        
    }

    private IEnumerator screenTimer()
    {
        yield return new WaitForSeconds(7.5f);
        NextScreen();
        StartCoroutine(screenTimer());
    }

    private void Update()
    {
        switch (index)
        {
            case 0:
                tutorialScreen[0].SetActive(true);
                if (tutorialScreen[3].activeInHierarchy)
                {
                    tutorialScreen[3].SetActive(false);
                }
                break;
            case 1:
                tutorialScreen[0].SetActive(false);
                tutorialScreen[1].SetActive(true);
                break;
            case 2:
                tutorialScreen[1].SetActive(false);
                tutorialScreen[2].SetActive(true);
                break;
            case 3:
                tutorialScreen[2].SetActive(false);
                tutorialScreen[3].SetActive(true);
                playButton.gameObject.SetActive(true);
                break;
        }

        if (index == 0)
        {
            tutorialScreen[0].SetActive(true);
        }
    }
}
