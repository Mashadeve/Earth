using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthController : MonoBehaviour
{
    [SerializeField] private ReadInput mouseOverSphere;
    private float horizontalInput, verticalInput;
    [SerializeField] private bool isDragged;

    private void Update()
    {
        if (isDragged)
        {
            horizontalInput = 0;
            verticalInput = 0;
            if (!mouseOverSphere.canDrag) return;
            EarthMove();
        }
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * horizontalInput);
        transform.Rotate(Vector3.left * verticalInput);      
    }

    private void EarthMove()
    {

        horizontalInput = Input.mousePosition.normalized.x;
        verticalInput = Input.mousePosition.normalized.y;
    }

    private void OnMouseDrag()
    {
        isDragged = true; 
    }

    private void OnMouseUp()
    {
        isDragged = false;
    }

}
