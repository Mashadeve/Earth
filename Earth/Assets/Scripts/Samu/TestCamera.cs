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

        transform.LookAt(target);
    }

    private void CameraTilt()
    {
        if (Input.GetAxis("Vertical") > 0 && transform.rotation.x < 0.6f)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime * 50));
        }
        else if (Input.GetAxis("Vertical") < 0 && transform.rotation.x > -0.6f)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime * 50));
        }
    }
}
