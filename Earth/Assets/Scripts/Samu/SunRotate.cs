using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotate : RotateScript
{

    private void Update()
    {
        RotatePlanet();
    }

    public override void RotatePlanet()
    {
        transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
    }
}
