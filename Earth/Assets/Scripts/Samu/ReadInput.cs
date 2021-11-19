using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class ReadInput : MonoBehaviour
{
    public bool canDrag;
    void Update()
    {
        MouseInput();
    }

    public void MouseInput()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;


        Physics.Raycast(ray, out hitData, 100f);

        //Debug.DrawRay(ray.origin, ray.direction, Color.red, 50f);
        
        canDrag = false;
        
        if (hitData.collider == null) return;
        canDrag = true;

    }
}
