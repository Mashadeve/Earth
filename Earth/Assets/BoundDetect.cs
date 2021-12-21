using UnityEngine;
using System.Collections.Generic;

public class BoundDetect : MonoBehaviour
{

    private Camera rayCam;

    private void Start()
    {
        rayCam = GetComponent<Camera>();

    }

    private void Update()
    {
        RayCastHit();
    }


    private void RayCastHit()
    {
        //Plane bounds = new Plane()

        int layerMask = 1 << 8;

        RaycastHit hit;

        var mousePos = rayCam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

        if (Physics.Raycast(transform.position, transform.TransformDirection(mousePos.direction), out hit, 200f, layerMask))
        {

            Debug.DrawRay(transform.position, transform.TransformDirection(mousePos.direction) * 200f, Color.red);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(mousePos.direction) * 200f, Color.white);
            Debug.Log("Did not Hit");
        }


        //}

        //private void FixedUpdate()
        //{
        //    RayCastHit();
        //}
    }
}
