using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneManager : MonoBehaviour
{
    [SerializeField] Material material;
    [SerializeField] Camera camera;

    private void Start()
    {
        
        var bounds = PlaneScript.CreatePlane(camera.scaledPixelWidth, camera.scaledPixelHeight, material);


    }
}
