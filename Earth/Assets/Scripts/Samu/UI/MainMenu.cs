using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button newGame, quitGame;
    [SerializeField] private GameObject createAPlayer, mainMenu;

    private void Awake()
    {
        createAPlayer.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void StartGame()
    {
        createAPlayer.SetActive(true);
        mainMenu.SetActive(false);
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
