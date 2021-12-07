using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthControllerSamunScene : MonoBehaviour
{
    //[SerializeField] private ReadInput mouseOverSphere;


    public Rigidbody rb;
    [SerializeField] private float rotationSpeed = 1500f;
    [SerializeField] private float multiplier;
    private float horizontalInput;

    private void Awake()
    {
        
    }

    private void OnMouseDrag()
    {
        
    }

    private void OnMouseUp()
    {
        
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
