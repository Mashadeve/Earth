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

    private void Update()
    {
        if (RaycastTest.hitTarget == null)
        {
            return;
        }
        else
        {
            index = RaycastTest.hitTarget.GetComponent<PlanetIndex>().index;
            nameDisplay.text = planetNameList[index];
            infoDisplay.text = planetInfoList[index];

            foreach (char letter in planetNameList[index].ToCharArray())
            {
                
                if (nameDisplay.text != planetNameList[index])
                {
                    nameDisplay.text += letter;                   
                }
                else
                {
                    break;
                }
                
            }

            Debug.Log("index " + index);
        }      
    }

    //public void StringToChar()
    //{
        
    //}

    //public IEnumerator TypeHeader()
    //{

    
    //}

    //public void NextHeader()
    //{
    //    if (index < planetNameList.Count)
    //    {           
    //        //index++;
    //        nameDisplay.text = "";           
    //    }
    //    else
    //    {
    //        nameDisplay.text = "";
    //    }
    //}

    //public IEnumerator TypeInfo()
    //{
    //    foreach (char letter in planetInfoList[index].ToCharArray())
    //    {
    //        infoDisplay.text += letter;
    //        yield return new WaitForSeconds(typingSpeed);
    //    }
    //}

    //public void NextInfo()
    //{
    //    if (index < planetInfoList.Count)
    //    {
    //        index++;
    //        infoDisplay.text = "";
    //    }
    //    else
    //    {
    //        infoDisplay.text = "";
    //    }
    //}

}
