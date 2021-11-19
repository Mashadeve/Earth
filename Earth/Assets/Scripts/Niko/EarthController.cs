using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthController : MonoBehaviour
{
    [SerializeField] private ReadInput mouseOverSphere;

    private float horizontalInput, verticalInput;
    [SerializeField] private bool isDragged;
    public Rigidbody rb;
    [SerializeField] private float rotationSpeed = 1500f;
    [SerializeField] private float multiplier;

    private void FixedUpdate()
    {
        

        if (isDragged)
        {
            //float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
            //float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down * horizontalInput);
            //rb.AddTorque(Vector3.right * horizontalInput);

        }       
    }

    private void EarthMove()
    {
        if (!mouseOverSphere.canDrag) return;
        horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed * multiplier * Time.fixedDeltaTime;
        verticalInput = Input.GetAxis("Mouse Y") * rotationSpeed * multiplier * Time.fixedDeltaTime;
    }


    private void OnMouseDrag()
    {
        isDragged = true;
        EarthMove();
    }

    private void OnMouseUp()
    {
        isDragged = false;
        horizontalInput = 0;
        verticalInput = 0;
    }

}
