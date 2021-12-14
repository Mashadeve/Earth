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


    private void Start()
    {
        index = FindObjectOfType<PlanetIndex>().index;
    }

    private void Update()
    {
        // vertaillaan raycast tulosta tässä textboxmanagerin indexiin.
        // about näin 
        // index = RaycastTest.hit.Gameobject.GetComponent<PlanetIndex>().index;
    }

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
        if (index < planetNameList.Count)
        {           
            index++;
            nameDisplay.text = "";           
        }
        else
        {
            nameDisplay.text = "";
        }
    }

    public IEnumerator TypeInfo()
    {
        foreach (char letter in planetInfoList[index].ToCharArray())
        {
            infoDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextInfo()
    {
        if (index < planetInfoList.Count)
        {
            index++;
            infoDisplay.text = "";
        }
        else
        {
            infoDisplay.text = "";
        }
    }

}
