using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotator : RotateScript
{
    private void Update()
    {
        RotatePlanet();
    }
    public override void RotatePlanet()
    {
        transform.Rotate(new Vector3(rotationSpeed, 0, 0) * Time.deltaTime);
    }
}
