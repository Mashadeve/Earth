using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBoxManager : MonoBehaviour
{
    public TextMeshProUGUI nameDisplay;
    public TextMeshProUGUI infoDisplay;
    public List<string> planetNameList = new List<string>();
    public List<string> planetInfoList = new List<string>();
    private int index;
    public float typingSpeed;


    public IEnumerator TypeHeader()
    {
        foreach(char letter in planetNameList[index].ToCharArray())
        {
            nameDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextHeader()
    {       
        if ( index < planetNameList.Count)
        {
            index++;
            nameDisplay.text = "";
            StartCoroutine(TypeHeader());
        }
        else
        {
            nameDisplay.text = "";
        }
    }

    public IEnumerator TypeInfo()
    {
        foreach(char letter in planetInfoList[index].ToCharArray())
        {
            infoDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }       
    }

    public void NextInfo()
    {
        //StartCoroutine(TypeInfo());

        if (index < planetInfoList.Count)
        {
            index++;
            infoDisplay.text = "";
            StartCoroutine(TypeInfo());
        }
        else
        {
            infoDisplay.text = "";
        }
    }

}
