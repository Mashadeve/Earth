using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCamera : MonoBehaviour
{
    public Transform target;
    [SerializeField] private float maxDistance;

    void Update()
    {
       

        CameraTilt();
        //if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
        //{
        //    transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime * 50));
        //    //transform.position = new Vector3(0,Input.GetAxis("Vertical") * Time.deltaTime * 100,-63);
        //}
        //if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        //{
        //    transform.Translate(new Vector3( Input.GetAxis("Horizontal") * Time.deltaTime * 50,0));
        //    //transform.Rotate(Vector3.right * verticalInput);

        //}

        transform.LookAt(target);
        // Rotate the camera every frame so it keeps looking at the target


        //if (target)
        //{
        //    float dist = Vector3.Distance(target.position, transform.position);
        //    if (dist > maxDistance)
        //    {
        //        dist = maxDistance;
        //    }
        //    print("Distance to other: " + dist);
        //}
        // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        //transform.LookAt(target, Vector3.left);
    }

    private void CameraTilt()
    {
        if (Input.GetAxis("Vertical") > 0 && transform.rotation.x < 0.6f)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime * 50));
            //transform.position = new Vector3(0,Input.GetAxis("Vertical") * Time.deltaTime * 100,-63);
        }else if (Input.GetAxis("Vertical") < 0 && transform.rotation.x > -0.6f)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime * 50));
        }
    }
}
