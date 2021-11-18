using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotate : RotateScript
{
    private void Update()
    {
        RotatePlanet();
    }
    public override void RotatePlanet()
    {
        transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
    }
}
