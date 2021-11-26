using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;


    private void Awake()
    {
        textBox.SetActive(false);
    }

    private void OnMouseOver()
    {
        if (textBox == null)
        {
            return;
        }

        textBox.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        textBox.gameObject.SetActive(false);
    }
}
