using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CursorScript
{
    public static void CursorOff(PartRaycast currentScript)
    {
        Cursor.visible = false;
    }

    public static void CursorOn(PartRaycast currentScrip)
    {
        Cursor.visible = true;
    }

    public static void ResetCursor()
    {
        Cursor.visible = true;
    }
}
