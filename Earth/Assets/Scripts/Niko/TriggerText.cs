using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    private TextBoxManager textBoxManager;

    private void Start()
    {
        textBoxManager = FindObjectOfType<TextBoxManager>();
    }

    //private void OnMouseEnter()
    //{
    //    StartCoroutine(textBoxManager.TypeHeader());
    //}

    //private void OnMouseExit()
    //{
    //    textBoxManager.NextHeader();
    //}
}
