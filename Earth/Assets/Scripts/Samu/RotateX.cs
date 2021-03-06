 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateX : MonoBehaviour
{
    private float verticalInput;
    private float rotationSpeed = 5;
    private float multiplier = 2;

    private void Update()
    {
        //if (Input.mouseScrollDelta.y > 0 || Input.mouseScrollDelta.y < 0)
        //{
        //    verticalInput = Input.mouseScrollDelta.y * rotationSpeed * multiplier * 10 * Time.fixedDeltaTime;
        //    transform.Rotate(Vector3.right * verticalInput);
        //}

        if (Input.GetAxisRaw("Vertical") > 0 || Input.GetAxisRaw("Vertical") < 0)
        {
            verticalInput = Input.GetAxisRaw("Vertical") * rotationSpeed * multiplier * 10f * Time.deltaTime;
            transform.Rotate(Vector3.right * verticalInput);
        }
    }
}
