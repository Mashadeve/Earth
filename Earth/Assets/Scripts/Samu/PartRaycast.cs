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
        if (!CanDrag.canDrag) return;
        CanDrag.onDrag = true;

    }

    private void OnMouseUp()
    {
        CanDrag.onDrag = false;
    }

    private void Update()
    {
        if (CanDrag.onDrag)
        {
            MoveObject();
        }
        
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

        transform.position = new Vector3(newWorldPosition.x + 5f, newWorldPosition.y - 10f, gameObject.transform.position.z);

    }

    //private void OnDrawGizmos()
    //{
    //    float maxDistance = 5f;

    //    RaycastHit hit;

    //    bool isHit = Physics.BoxCast(transform.position, transform.lossyScale / 2, transform.forward ,out hit, transform.rotation, maxDistance);
    //    if (isHit)
    //    {
    //        Gizmos.color = Color.red;
    //        Gizmos.DrawRay(transform.position, transform.forward * hit.distance);
    //        Gizmos.DrawWireCube(transform.position + transform.forward * hit.distance, transform.lossyScale);
    //    }

    //}
}

