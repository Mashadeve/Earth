using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapper : MonoBehaviour
{
    public GameObject target, targetAnchor, trail;
    private Vector3 startPos;
    private bool posIsSet;
    [HideInInspector]public bool isPlaced;

    private void Start()
    {
        trail.SetActive(false);
    }

    private void OnMouseDown()
    {        
        if (target.transform.position == targetAnchor.transform.position)
        {
            if (target.GetComponent<Move3D>() == null)
            {
                //target.AddComponent<Move3D>();

            }
        }
        else if (target.transform.position != targetAnchor.transform.position)
        {
            return;
        }
    }

    private void OnMouseDrag()
    {
        Cursor.visible = false;

        if (startPos != transform.position && !posIsSet)
        {
            startPos = transform.position;
            posIsSet = true;
        }
    }

    private void OnMouseUp()
    {
        if (target.GetComponent<Move3D>() == null)
        {
            //target.AddComponent<Move3D>();
        }

        Cursor.visible = true;

        if (transform.position != targetAnchor.transform.position)
        {
            transform.position = startPos;
        }
    }

    private void OnTriggerEnter(Collider targetAnchor)
    {       
        if (target.CompareTag(targetAnchor.tag))
        {
            target.transform.position = targetAnchor.transform.position;

            target.transform.SetParent(targetAnchor.gameObject.transform);

            targetAnchor.GetComponentInParent<SunRotate>().enabled = true;

            trail.SetActive(true);

            Destroy(target.GetComponent<Move3D>());

            isPlaced = true;

        }
        else
        {
            target.transform.position = targetAnchor.transform.position;
        }
    }
}
