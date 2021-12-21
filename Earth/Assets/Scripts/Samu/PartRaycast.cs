using UnityEngine;

public class PartRaycast : MonoBehaviour
{
    private Camera mainCamera;
    private float cameraZDistance;
    private Vector3 startPos;
    private bool posIsSet;

    private void Start()
    {
        mainCamera = Camera.main;
        cameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
    }

    private void OnMouseDrag()
    {
        if (startPos != transform.position && !posIsSet)
        {
            startPos = transform.position;
            posIsSet = true;
        }
        CursorScript.onDrag = true;
        Cursor.visible = false;
        MoveP();
        

    }

    private void OnMouseUp()
    {
        Cursor.visible = true;
        CursorScript.onDrag = false;

        if (transform.position != GameObject.Find("Earth_10").transform.position)
        {
            transform.position = startPos;
        }
    }

    private void MoveP()
    {
        Vector3 pos = transform.position;
        Vector3 corePos = GameObject.Find("Earth_10").transform.position;

        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);
        Vector3 newWorldPosition = mainCamera.ScreenToWorldPoint(screenPosition);
        
        transform.position = new Vector3(newWorldPosition.x, newWorldPosition.y, gameObject.transform.position.z); 
    }
}

