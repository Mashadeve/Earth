using UnityEngine;

public class PartRaycast : MonoBehaviour
{
    private Camera mainCamera;
    private float cameraZDistance;
    //[SerializeField] private LayerMask layerMask;
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
        //if (!CanDrag.canDrag) return;
        //CanDrag.onDrag = true;

    }

    private void OnMouseUp()
    {

        Cursor.visible = true;
        CursorScript.onDrag = false;
    }

    private void Update()
    {
        //if (CanDrag.onDrag)
        //{
        //    MoveObject();
        //}
        
        //Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);
        //Vector3 newWorldPosition = mainCamera.ScreenToWorldPoint(screenPosition);

        //Ray ray = new Ray(mainCamera.transform.position, gameObject.transform.position);
        //Debug.DrawRay(ray.origin, ray.direction, Color.blue);
        ////RaycastHit hit;
        ////Physics.Raycast(ray, out hit, layerMask);
        ////transform.position = new Vector3(newWorldPosition.x, newWorldPosition.y, gameObject.transform.position.z);
    }

    private void MoveObject()
    {
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);
        Vector3 newWorldPosition = mainCamera.ScreenToWorldPoint(screenPosition);

        transform.position = new Vector3(newWorldPosition.x, newWorldPosition.y, gameObject.transform.position.z);

        //RayCastHit();

    }
}

