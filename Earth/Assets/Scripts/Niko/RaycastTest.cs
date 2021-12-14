using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastTest : MonoBehaviour
{
    
    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 500f))
        {    
            // Tässä objektissa on yksilötieto ja tästä meidän pitää hakea planeIndex scripti
            // tätä käytetään TextBoxManagerin indexin vertailuun
            Debug.Log(hit.collider.name);                                  
        }        
    }   
}
