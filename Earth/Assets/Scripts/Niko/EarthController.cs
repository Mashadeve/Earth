using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthController : MonoBehaviour
{
    private float horizontalInput, verticalInput;

    private void Update()
    {
        if (MouseInput == true)
        {
            horizontalInput = Input.mousePosition.normalized.x;
            verticalInput = Input.mousePosition.normalized.y;
        }        
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * horizontalInput);
        transform.Rotate(Vector3.left * verticalInput);      
    }

}
