using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Texture2D cursor;

    public void ChangeCursor(Texture2D cursor)
    {
        Vector3 hotspot = new Vector3(cursor.width / 2, cursor.height / 2, 88f);
        Cursor.SetCursor(cursor, hotspot, CursorMode.Auto);
    }

    private void Awake()
    {
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
    }
}
