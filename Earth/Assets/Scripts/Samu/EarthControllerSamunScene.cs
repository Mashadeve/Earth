using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthControllerSamunScene : MonoBehaviour
{
    [SerializeField] private ReadInput mouseOverSphere;

    private float verticalInput, horizontalInput;
    [SerializeField] private bool isDragged;
    public Rigidbody rb;
    [SerializeField] private float rotationSpeed = 1500f;
    [SerializeField] private float multiplier;

    private void FixedUpdate()
    {
        //rb.AddTorque(Vector3.down * horizontalInput);
        //rb.AddTorque(Vector3.right * verticalInput);




        //if (isDragged)
        {
            //float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
            //float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime;



        }
    }

    private void EarthMove()
    {
        //if (!mouseOverSphere.canDrag) return;
        //horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed * multiplier * Time.fixedDeltaTime;
        //verticalInput = Input.GetAxis("Mouse Y") * rotationSpeed * multiplier * Time.fixedDeltaTime;



    }


    private void OnMouseDrag()
    {
        isDragged = true;
        //EarthMove();
    }

    private void OnMouseUp()
    {
        isDragged = false;
        verticalInput = 0;
        horizontalInput = 0;
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            horizontalInput = Input.GetAxis("Horizontal") * rotationSpeed * multiplier * Time.fixedDeltaTime;
            transform.Rotate(Vector3.down * horizontalInput);
        }





    }
}
