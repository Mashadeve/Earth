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
    }


    private void RayCastHit()
    {
        RaycastHit hit;

        Vector3 mousePos = Input.mousePosition;
        var mouseOnScreen = rayCam.ScreenPointToRay(mousePos);

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
    }
}
