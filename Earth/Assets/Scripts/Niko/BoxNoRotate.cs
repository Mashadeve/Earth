using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxNoRotate : MonoBehaviour
{
    public Vector3 worldOffset;
    public GameObject target;

    private void LateUpdate()
    {
        transform.position = target.transform.position + worldOffset;
    }
}
