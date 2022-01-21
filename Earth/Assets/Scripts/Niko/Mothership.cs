using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mothership : MonoBehaviour
{

    public void GameSelection()
    {
        SceneManager.LoadScene("GameSelection");
    }

    public void Earth()
    {
        SceneManager.LoadScene("TutorialSamu");
    }

    public void SolarSystem()
    {
        SceneManager.LoadScene("NikonScene");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }
}
