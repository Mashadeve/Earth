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
    [SerializeField] private SaveData playerData;
    string playerName;

    public void StoreName()
    {
        playerData.playerNickname = inputField.GetComponent<TMP_Text>().text;
        playerData.SaveGame();
        //SceneManager.LoadScene(1);   
    }

    public void LoadName()
    {
        playerData.LoadData();
        Debug.Log(playerData.playerNickname);
    }
}
