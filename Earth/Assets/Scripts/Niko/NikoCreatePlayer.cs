using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NikoCreatePlayer : MonoBehaviour
{
    [SerializeField] private GameObject inputField;
    string playerNames;

    public void StoreName()
    {
        playerNames = inputField.GetComponent<TMP_Text>().text;
    }
}
