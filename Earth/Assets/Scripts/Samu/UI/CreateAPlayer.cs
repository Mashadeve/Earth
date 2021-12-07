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
    SaveData playerDB;
    string playerName;

    public void StoreName()
    {
        playerDB = GameObject.Find("GameManager").GetComponent<SaveData>();
        playerDB.playerNickname = inputField.GetComponent<TMP_Text>().text;
        playerDB.SaveGame();
        //SceneManager.LoadScene(1);   
    }

    public void LoadName()
    {
        playerDB.LoadData();
        Debug.Log(playerDB.playerNickname);
    }
}
