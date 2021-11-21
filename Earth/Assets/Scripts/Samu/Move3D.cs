using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3D : MonoBehaviour
{
    private Camera mainCamera;
    private float cameraZDistance;

    private GameObject currentObject, sun, sunAnchor;

    private bool mouseOver;
    private bool canMovePieces;

    private void Start()
    {
        mainCamera = Camera.main;
        cameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
    }

    private void OnMouseDrag()
    {
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);
        Vector3 newWorldPosition = mainCamera.ScreenToWorldPoint(screenPosition);

        transform.position = new Vector3(newWorldPosition.x, newWorldPosition.y, gameObject.transform.position.z);
    }

}
