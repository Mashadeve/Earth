using UnityEngine;

public class CoreAngle : MonoBehaviour
{
    private void Update()
    {
        GetAngle();
    }

    private void GetAngle()
    {
        Vector3 eulerToVector3 = transform.localRotation.eulerAngles;
        
    }
   
}
