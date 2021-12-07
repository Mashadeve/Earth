using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CreateAPlayer : MonoBehaviour
{
    [SerializeField] private GameObject inputField;
    [SerializeField] private GameObject textDisplay;
    [SerializeField] private GameData playerData;
    string playerName;

    public void StoreName()
    {
        playerData = GameObject.Find("GameManager").GetComponent<GameData>();
        playerData.playerNickname = inputField.GetComponent<TMP_Text>().text;
        playerData.SaveGame();
        //SceneManager.LoadScene(1);   
    }

    public void LoadName()
    {
        playerData.LoadData();
    }
}
