using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class TutorialController : MonoBehaviour
{
    [SerializeField] private List<GameObject> tutorialScreen = new List<GameObject>();

    private int index;

    private void Start()
    {
        for (int i = 0; i < tutorialScreen.Count; i++)
        {
            tutorialScreen[i].SetActive(false);
        }
        tutorialScreen[0].SetActive(true);
    }

    public void NextScreen()
    {
        index++;
    }

    private void Update()
    {
        
        if (index < tutorialScreen.Count)
        {
            tutorialScreen[index].SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(2);
        }

        
    }
}
