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
            // T�ss� objektissa on yksil�tieto ja t�st� meid�n pit�� hakea planeIndex scripti
            // t�t� k�ytet��n TextBoxManagerin indexin vertailuun
            Debug.Log(hit.collider.name);                                  
        }        
    }   
}
