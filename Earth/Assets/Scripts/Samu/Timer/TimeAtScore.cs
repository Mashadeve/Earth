using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAtScore : MonoBehaviour
{
    public float time;

    private void Update()
    {
        time += Time.deltaTime;
    }
}
