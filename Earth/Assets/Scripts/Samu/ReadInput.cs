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

        Physics.Raycast(ray, out hitData, 200f);

        canDrag = false;
        
        if (hitData.collider == null) return;
        canDrag = true;
    }
}
