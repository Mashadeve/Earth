using UnityEngine;

public class CanDrag : MonoBehaviour
{
    private Camera rayCam;
    public static bool canDrag, onDrag;
    private Vector3 hitRayPos;
    private GameObject hitTarget;

    private void Start()
    {
        rayCam = GetComponent<Camera>();


    }

    private void Update()
    { 

        if (onDrag)
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }

        

        if (onDrag)
        {
            MoveObject(hitTarget);
        }
    }



    private void OnMouseDrag()
    {
        onDrag = true;
    }

    private void MoveObject(GameObject earthPart)
    {
        earthPart.transform.position = new Vector3(hitRayPos.x, hitRayPos.y, earthPart.transform.position.z);
    }

    private void RayCastHit()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 6;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        //layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        var mousePos = rayCam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

        //Debug.DrawRay(transform.position, mousePos.direction * 100f, Color.red);
        if (Physics.Raycast(transform.position, transform.TransformDirection(mousePos.direction), out hit, Mathf.Infinity, layerMask))
        {
            hitRayPos = hit.point;
            hitTarget = hit.collider.gameObject;
            Debug.DrawRay(transform.position, transform.TransformDirection(mousePos.direction) * hit.distance, Color.yellow);
            //Debug.Log("Did Hit " + hit.collider.gameObject.name);
            canDrag = true;



        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(mousePos.direction) * 1000, Color.white);
            Debug.Log("Did not Hit");
            canDrag = false;
        }

        
    }

    private void FixedUpdate()
    {
        RayCastHit();
    }
}
