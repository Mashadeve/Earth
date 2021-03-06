using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthController : MonoBehaviour
{
    [SerializeField] private ReadInput mouseOverSphere;

    private float horizontalInput, verticalInput;
    [SerializeField] private bool isDragged;
    private float rotationSpeed = 1500f;


    private void EarthMove()
    {
        if (!mouseOverSphere.canDrag) return;
        horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
        verticalInput = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime;
    }

    private void OnMouseDrag()
    {
        
        EarthMove();
    }

    private void OnMouseUp()
    {
        
        horizontalInput = 0;
        verticalInput = 0;
    }

}
