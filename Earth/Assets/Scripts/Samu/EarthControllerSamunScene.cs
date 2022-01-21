using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthControllerSamunScene : MonoBehaviour
{
    
    [SerializeField] private float rotationSpeed = 50f;
    [SerializeField] private float multiplier = 1f;
    private float horizontalInput;

    private void OnMouseUp()
    {
        horizontalInput = 0;
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            horizontalInput = Input.GetAxis("Horizontal") * rotationSpeed * multiplier * Time.deltaTime;
            transform.Rotate(Vector3.down * horizontalInput);
        }
    }
}
