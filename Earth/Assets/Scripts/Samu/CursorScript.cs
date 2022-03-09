using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CursorScript
{
    public static void CursorOff(MoveContinent currentScript)
    {
        Cursor.visible = false;
    }

    public static void CursorOn(MoveContinent currentScrip)
    {
        Cursor.visible = true;
    }

    public static void ResetCursor()
    {
        Cursor.visible = true;
    }
}
