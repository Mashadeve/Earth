using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastTest : MonoBehaviour
{
    public static GameObject hitTarget;
  
    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 3000f))
        {
            hitTarget = hit.collider.gameObject;
            Debug.Log(hit.collider.name);
        }
    }   
}
