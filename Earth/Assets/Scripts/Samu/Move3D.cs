using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3D : MonoBehaviour
{
    private Camera mainCamera;
    private float cameraZDistance;
    //[SerializeField] private GameObject piece;

    [SerializeField] private LayerMask layermask;

    //[SerializeField] private Material defaultMaterial;
    //[SerializeField] private Texture defaultTexture;

    private GameObject currentObject;

    private bool mouseOver;
    private bool canMovePieces;

    private void Start()
    {
        mainCamera = Camera.main;
        cameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
    }

    private void Update()
    {
        if (!mouseOver && currentObject != null)
        {
            //currentObject.GetComponent<MeshRenderer>().material = defaultMaterial;
            //currentObject.GetComponent<MeshRenderer>().material.mainTexture = defaultTexture;
        }
    }

    private void OnMouseDrag()
    {
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);
        Vector3 newWorldPosition = mainCamera.ScreenToWorldPoint(screenPosition);
        
        transform.position = new Vector3(newWorldPosition.x, newWorldPosition.y, gameObject.transform.position.z);
    }

    //public void MouseInput()
    //{


    //    mouseOver = false;

    //    if (hitData.collider == null) return;

    //    if (hitData.collider.name == "Seas")
    //    {
    //        canDrag = true;
    //        currentObject = hitData.collider.gameObject;
    //        currentObject.GetComponent<MeshRenderer>().material = defaultMaterial;
    //        currentObject.GetComponent<MeshRenderer>().material.mainTexture = defaultTexture;
    //        mouseOver = true;
    //    }

    //    mouseOver = true;
    //    if (mouseOver && hitData.collider.name != "Seas")
    //    {
    //        currentObject = hitData.collider.gameObject;
    //        //currentObject.transform.parent.localPosition = Vector3.zero;
    //        currentObject.GetComponent<MeshRenderer>().material.color = new Color(0.3f, 0, 0, 0.5f);
    //        Debug.Log(currentObject);

    //    }
    //}
}
