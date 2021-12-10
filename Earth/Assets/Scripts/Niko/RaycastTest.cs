using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastTest : MonoBehaviour
{
    [SerializeField] public GameObject cursorImage;

    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.direction * 1000f, Color.red);


        if (Physics.Raycast(ray, out hit, 500f))
        {
            //newCursor.transform.position = new Vector3(hit.collider.transform.position.x,
            //                                               hit.collider.transform.position.y,
            //                                               hit.collider.gameObject.transform.position.z);

            Debug.Log(hit.collider);
                                    
        }        
    }   
}
