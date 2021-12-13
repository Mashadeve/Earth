using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mothership : MonoBehaviour
{
    public void Earth()
    {
        SceneManager.LoadScene(1);
    }

    public void SolarSystem()
    {
        SceneManager.LoadScene(3);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }
}
