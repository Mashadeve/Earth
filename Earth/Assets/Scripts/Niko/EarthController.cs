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
        

    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * horizontalInput);
        transform.Rotate(Vector3.left * verticalInput);      
    }

    private void EarthMove()
    {
        if (!mouseOverSphere.canDrag) return;
        horizontalInput = Input.mousePosition.normalized.x;
        verticalInput = Input.mousePosition.normalized.y;
    }

    private void OnMouseDrag()
    {
        Debug.Log("HEHE");
        EarthMove();
    }

    private void OnMouseUp()
    {
        horizontalInput = 0;
        verticalInput = 0;
    }

}
