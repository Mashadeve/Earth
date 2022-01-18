using UnityEngine;

public class PartRaycast : MonoBehaviour
{
    private Camera rayCam;
    private float cameraZDistance;
    private Vector3 startPos, offset;
    private bool posIsSet;
    public static Color matColorDefault, currentColor;
    private Material material;
    private GameObject core;
    //*******Mask********
    private int defaultMask, highlightMask;

    private void Start()
    {
        core = GameObject.Find("Core");

        material = GetComponentInChildren<MeshRenderer>().material;
        matColorDefault = material.color;
        rayCam = GameObject.Find("hightlightCam").GetComponent<Camera>();
        cameraZDistance = rayCam.WorldToScreenPoint(transform.position).z;

        //********Mask*********
        defaultMask = LayerMask.NameToLayer("Parts");
        highlightMask = LayerMask.NameToLayer("Highlight");
    }

    private void OnMouseDown()
    {
        offset = gameObject.transform.position - MoveP();
    }

    private void OnMouseDrag()
    {
        CursorScript.CursorOff(this);
        
        if (startPos != transform.position && !posIsSet)
        {
            startPos = transform.position;
            posIsSet = true;
        }
        CorrectAngle.CalcAngle(core, this.gameObject);

        transform.position = new Vector3(MoveP().x, MoveP().y, transform.position.z) + offset;
        
        if (CorrectAngle.canSnapNew)
        {
            var child = transform.GetChild(0).gameObject;
            child.layer = 9;
        }
        else
        {
            var child = transform.GetChild(0).gameObject;
            child.layer = 11;
        }
    }

    private void OnMouseUp()
    {
        CursorScript.CursorOn(this);

        var child = transform.GetChild(0).gameObject;
        child.layer = 6;

        if (transform.position != GameObject.Find("Earth_10").transform.position)
        {
            transform.position = startPos;
        }
    }

    private Vector3 MoveP()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = cameraZDistance;

        return rayCam.ScreenToWorldPoint(mousePos);
    }
}

