using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : TextBoxManager
{

    private void OnMouseEnter()
    {
        StartCoroutine(TypeHeader());
    }

    private void OnMouseExit()
    {
        StopCoroutine(TypeHeader());
    }
}
