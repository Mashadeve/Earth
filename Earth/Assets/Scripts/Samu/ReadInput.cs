using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    [SerializeField] private bool canDrag;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;

        if (Physics.Raycast(ray, out hitData, 100) && hitData.transform.tag == "Earth")
        {
            Debug.Log("Mouse is over the Earth");
            canDrag = true;

        }
        else
        {
            Debug.Log("Mouse is not over the Earth");
            canDrag = false;
        }
    }
}
