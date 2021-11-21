using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapper : MonoBehaviour
{
    public GameObject target, targetAnchor;

    private void OnMouseDown()
    {
        if (target.transform.position == targetAnchor.transform.position)
        {
            if (target.GetComponent<Move3D>() == null)
            {
                target.AddComponent<Move3D>();
            }
        }
        else if (target.transform.position != targetAnchor.transform.position)
        {
            return;
        }
    }

    private void OnMouseUp()
    {
        if (target.GetComponent<Move3D>() == null)
        {
            target.AddComponent<Move3D>();
        }
    }

    private void OnTriggerEnter(Collider targetAnchor)
    {
        target.transform.position = targetAnchor.transform.position;

        Destroy(target.GetComponent<Move3D>());

        Debug.Log("OSUU");  
    }
}
