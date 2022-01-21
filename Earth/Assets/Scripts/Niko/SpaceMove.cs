using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceMove : MonoBehaviour
{
    [SerializeField] public RawImage img;
    [SerializeField] public float x, y;

    void Update()
    {
        img.uvRect = new Rect(img.uvRect.position + new Vector2(x, y) * Time.deltaTime, img.uvRect.size);
    }

}
