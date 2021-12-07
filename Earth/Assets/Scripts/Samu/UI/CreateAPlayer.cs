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
    PlayerDatabase playerDB;
    string playerName;

    public void StoreName()
    {
        playerDB = GameObject.Find("GameManager").GetComponent<PlayerDatabase>();
        playerDB.playerNickname = inputField.GetComponent<TMP_Text>().text;
        SceneManager.LoadScene(1);   
    }
}
