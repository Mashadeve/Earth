using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Transform target;    
    public float max, min, range;
    

    private void Start()
    {
        max = 80;
        min = 10;

        Camera.main.fieldOfView = 60f;
    }

    private void Update()
    {
        transform.LookAt(target);

        ZoomCamera();
    }

    public void ZoomCamera()
    {
        if (Input.mouseScrollDelta.y < 0 && Camera.main.fieldOfView < max)
        {
            Camera.main.fieldOfView += 5;
        }
        else if (Input.mouseScrollDelta.y > 0 && Camera.main.fieldOfView > min)
        {
            Camera.main.fieldOfView -= 5;
        }
    }

    //void OnGUI()
    //{
    //    //Set up the maximum and minimum values the Slider can return (you can change these)
    //    float max, min;
    //    max = 80.0f;
    //    min = 20.0f;
    //    //This Slider changes the field of view of the Camera between the minimum and maximum values
    //    Camera.main.fieldOfView = GUI.HorizontalSlider(new Rect(50, 200, 100, 40), Camera.main.fieldOfView, min, max);
    //}

}
