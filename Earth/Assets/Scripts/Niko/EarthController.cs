using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthController : MonoBehaviour
{
    [SerializeField] private ReadInput mouseInput;
    private float horizontalInput, verticalInput;


    private void Update()
    {
        if (mouseInput.canDrag == true)
        {          
            horizontalInput = Input.mousePosition.normalized.x;
            verticalInput = Input.mousePosition.normalized.y;
        } 
        else if (mouseInput.canDrag == false)
        {
            
        }
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * horizontalInput);
        transform.Rotate(Vector3.left * verticalInput);      
    }

}
