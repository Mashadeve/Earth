using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class ReadInput : MonoBehaviour
{
    [SerializeField] public bool canDrag;
    [SerializeField] private LayerMask layermask;

    void Update()
    {
        MouseInput();
    }

    public void MouseInput()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;


        Physics.Raycast(ray, out hitData, 100f, layermask);

        Debug.DrawRay(ray.origin, ray.direction, Color.red, 50f);

        if (hitData.collider == null) return;
        var thing = hitData.collider.gameObject;
        thing.GetComponent<MeshRenderer>().material.color = Color.red;
        Debug.Log(thing);

        canDrag = false;

        if (hitData.collider == null) return;
        canDrag = true;
    }
}
