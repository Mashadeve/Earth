using UnityEngine;

public class PartRaycast : MonoBehaviour
{
    private Camera rayCam;
    private float cameraZDistance;
    private Vector3 startPos;
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

    private void OnMouseDrag()
    {
        CursorScript.CursorOff(this);

        if (startPos != transform.position && !posIsSet)
        {
            startPos = transform.position;
            posIsSet = true;
        }
        CorrectAngle.CalcAngle(core, this.gameObject);

        MoveP();

        if (CorrectAngle.canSnapNew)
        {
            var child = transform.GetChild(0).gameObject;
            child.layer = 9;
            //material.color = Color.green;
        }
        else
        {
            var child = transform.GetChild(0).gameObject;
            child.layer = 11;
            //material.color = Color.red;

        }
    }

    private void OnMouseUp()
    {
        CursorScript.CursorOn(this);

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
        Vector3 newWorldPosition = rayCam.ScreenToWorldPoint(screenPosition);

        transform.position = new Vector3(newWorldPosition.x, newWorldPosition.y, gameObject.transform.position.z);
    }
}

