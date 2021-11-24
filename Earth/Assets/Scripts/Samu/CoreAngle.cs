using UnityEngine;

public class CoreAngle : MonoBehaviour
{
    private void Update()
    {
        GetAngle();
    }

    private void GetAngle()
    {
        Quaternion eulerToVector3 = new Quaternion(Mathf.RoundToInt(transform.rotation.x * 180), transform.rotation.y, transform.rotation.z, transform.rotation.w);
        Debug.Log(eulerToVector3);
        
    }
   
}
