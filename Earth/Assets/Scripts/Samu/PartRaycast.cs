using UnityEngine;

public class PartRaycast : MonoBehaviour
{
    private Camera mainCamera;
    private float cameraZDistance;

    private void Start()
    {
        mainCamera = Camera.main;
        cameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
    }
    private void OnMouseDrag()
    {
        MoveObject();
        CursorScript.onDrag = true;
        Cursor.visible = false;
    }

    private void OnMouseUp()
    {
        Cursor.visible = true;
        CursorScript.onDrag = false;
    }

    private void MoveObject()
    {
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);
        Vector3 newWorldPosition = mainCamera.ScreenToWorldPoint(screenPosition);

        transform.position = new Vector3(newWorldPosition.x, newWorldPosition.y, gameObject.transform.position.z);
    }
}

