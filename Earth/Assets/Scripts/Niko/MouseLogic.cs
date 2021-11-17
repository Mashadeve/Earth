using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLogic : MonoBehaviour
{
    private Vector3 startPosition, worldPos, mousePosCurrent, currentMousePos;
    private float distance;
    Camera cam;

    private void Start()
    {
        startPosition = Vector3.zero;
        cam = Camera.main;
    }
    private void Update()
    {
        OnMoveTouch();
    }
    
    private void OnMoveTouch()
    {

        mousePosCurrent = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        currentMousePos = cam.ViewportToWorldPoint(mousePosCurrent);
        currentMousePos.z = 0f;
        
        //Debug.Log(currentMousePos);

        //currentMousePos.z = 0f;
        //transform.position = currentMousePos;
        //distance = Vector2.Distance(startPosition, currentMousePos);
        //Debug.Log(distance);
    }
    //private void DetectedTouch()
    //{
    //    if (Input.touchCount > 0)
    //    {

    //        Touch touch = Input.GetTouch(0);
    //        //Debug.Log(touch.phase);
    //        // Handle finger movements based on TouchPhase
    //        switch (touch.phase)
    //        {
    //            //When a touch has first been detected, change the message and record the starting position
    //            case TouchPhase.Began:
    //                OnStartTouch();
    //                break;

    //            //Determine if the touch is a moving touch
    //            case TouchPhase.Moved:
    //                OnMoveTouch();
    //                Mouse();

    //                touchEnd = false;
    //                break;

    //            case TouchPhase.Ended:
    //                // Report that the touch has ended when it ends
    //                OnEndTouch();
    //                break;
    //        }
    //    }
    //    else
    //    {
    //        touchEnd = true;
    //    }
    //}
}
