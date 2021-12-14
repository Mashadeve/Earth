using UnityEngine;
using System.Collections.Generic;

public class CanDrag : MonoBehaviour
{
    
    //private Camera rayCam;
    ////public static bool canDrag, onDrag;
    //private Vector3 hitRayPos;
    //private GameObject hitTarget;
    //private List<GameObject> partsList;
    

    //private void Start()
    //{
    //    rayCam = GetComponent<Camera>();
    //    partsList = FindObjectOfType<SnapPoints>().originalPart;
    //}

    //private void Update()
    //{
        
        
    //    if (onDrag)
    //    {
    //        Cursor.visible = false;
    //    }
    //    else
    //    {
    //        Cursor.visible = true;
    //    }

        

    //    if (onDrag)
    //    {
    //        MoveObject(hitTarget);
    //        Debug.Log("hitrayPos " + hitRayPos);
    //    }
    //}



    //private void OnMouseDrag()
    //{
    //    onDrag = true;
    //}

    //private void MoveObject(GameObject earthPart)
    //{
    //    earthPart.transform.position = new Vector3(hitRayPos.x, hitRayPos.y, earthPart.transform.position.z);
    //}

    //private void RayCastHit()
    //{
    //    int layerMask = 1 << 6;

    //    RaycastHit hit;
       
    //    var mousePos = rayCam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

    //    if (Physics.Raycast(transform.position, transform.TransformDirection(mousePos.direction), out hit, 200f, layerMask))
    //    {
    //        hitRayPos = hit.point;
    //        hitTarget = hit.collider.gameObject;
    //        Debug.DrawRay(transform.position, transform.TransformDirection(mousePos.direction) * 200f, Color.yellow);
    //        //Debug.Log("Did Hit " + hit.collider.gameObject.name);
    //        canDrag = true;
    //    }
    //    else
    //    {
    //        Debug.DrawRay(transform.position, transform.TransformDirection(mousePos.direction) * 200f, Color.white);
    //        Debug.Log("Did not Hit");
    //        canDrag = false;
    //    }

        
    //}

    //private void FixedUpdate()
    //{
    //    RayCastHit();
    //}
}
