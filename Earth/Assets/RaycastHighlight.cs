using UnityEngine;
using System.Collections.Generic;

public class RaycastHighlight : MonoBehaviour
{

    private Camera rayCam;
    private int highlightMask, defaultMask, backgroundMask;
    public static GameObject currentTarget, target;
    private void Start()
    {
        rayCam = GetComponent<Camera>();
        defaultMask = LayerMask.NameToLayer("Parts");
        highlightMask = LayerMask.NameToLayer("Highlight");
        backgroundMask = LayerMask.NameToLayer("Background");


    }

    private void Update()
    {
        RayCastHit();
        if (target != null)
        {
            Debug.Log("TARGET: " + target);
        }
        
    }


    private void RayCastHit()
    {
        //Plane bounds = new Plane()

        //int layerMask = 1 << 8;
        RaycastHit hit;

        Vector3 mousePos = Input.mousePosition;
        var mouseOnScreen = rayCam.ScreenPointToRay(mousePos);

        //var mousepos = rayCam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        //Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.y);
        //screenPosition.z = 0;

        //Vector3 newWorldPosition = rayCam.ScreenToWorldPoint(Input.mousePosition);
        //Debug.DrawRay(transform.position, mouseOnScreen.direction * 200, Color.green);

        if (Physics.Raycast(transform.position, mouseOnScreen.direction, out hit, 300f, LayerMask.GetMask("Parts", "Highlight", "Background")))
        {
            Debug.DrawRay(transform.position, mouseOnScreen.direction * 300, Color.green);

            target = hit.collider.gameObject;


            if (target.name == "Background")
            {
                if (currentTarget != null)
                {
                    currentTarget.transform.GetChild(0).gameObject.layer = 6;
                    currentTarget = null;
                }
                else
                {
                    return;
                }


            }
            else if (target.layer == 6)
            {
                Debug.DrawRay(transform.position, mouseOnScreen.direction * 300, Color.blue);
                currentTarget = target;
            }
        }

        else
        {
            if (target != null)
            {
                target = null;
            }

        }



        //if (Physics.Raycast(ray, out hit, 200f, LayerMask.GetMask("Parts", "Hightlight")))
        //{
        //    //Debug.DrawRay(transform.position, transform.TransformDirection(mousePos.direction) * 200f, Color.red);
        //    

        //    Debug.Log(target.name);

        //    if (currentTarget != target)
        //    {
        //        currentTarget = target;
        //        currentTarget.layer = highlightMask;

        //    }
        //    //else if (currentTarget != null)
        //    //{
        //    //    currentTarget.layer = defaultMask;
        //    //    currentTarget = null;
        //    //}

        //}
        //else
        //{
        //    target.layer = defaultMask;
        //}

        //var mousePos = rayCam.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

        //if (Physics.Raycast(transform.position, transform.TransformDirection(mousePos.direction), out hit, 200f, LayerMask.GetMask("Parts","Hightlight")))
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(mousePos.direction) * 200f, Color.red);
        //    GameObject target = hit.collider.gameObject;
        //    if (currentTarget != target)
        //    {
        //        currentTarget = target;
        //        currentTarget.layer = highlightMask;

        //    }else if (currentTarget != null)
        //    {
        //        currentTarget.layer = defaultMask;
        //        currentTarget = null;
        //    }

        //}
        //else
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(mousePos.direction) * 200f, Color.white);
        //    Debug.Log("Did not Hit");
        //}


        //}

        //private void FixedUpdate()
        //{
        //    RayCastHit();
        //}
    }
}
