using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CorrectAngle
{
    private static float snapAngleRange = 10f;
    public static bool canSnapNew;


    public static bool CalcAngle(GameObject core, GameObject target)
    {
        //Debug.Log("targetRot " + target.transform.rotation);
        //Debug.Log("coreRotInCorrectAngles " + core.transform.rotation);

        var coreQuat = core.transform.rotation;
        var targetQuat = target.transform.rotation;
        float angleX = Quaternion.Angle(coreQuat, targetQuat);
        float angleY = Quaternion.Angle(coreQuat, targetQuat);

        //Debug.Log("AngleX " + angleX);
        //Debug.Log("AngleY " + angleY);

        if (angleX < snapAngleRange && angleY < snapAngleRange)
        {
            canSnapNew = true;
            return true;
        }
        else
        {
            canSnapNew = false;
            return false;
        }

    }
}
