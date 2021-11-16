using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    [SerializeField] public bool canDrag;

    void Update()
    {
        MouseInput();
    }

    public void MouseInput()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;


        Physics.Raycast(ray, out hitData, 100);
        canDrag = false;

        if (hitData.collider == null) return;
        canDrag = true;
    }
}
