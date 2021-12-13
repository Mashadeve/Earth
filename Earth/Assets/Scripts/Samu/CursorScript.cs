using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public static bool onDrag;

    private void Update()
    {
        Debug.Log("OnDrag status " + onDrag);

        if (!onDrag)
        {
            Cursor.visible = true;
        }
    }
}
