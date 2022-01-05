using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Completed : MonoBehaviour
{
    public GameObject completed;
    public List<GameObject> planets = new List<GameObject>();
    
    private void Update()
    {
       
        for (int i = 0; i < planets.Count; i++)
        {                    
            if (planets[i].GetComponent<Snapper>().isPlaced == true)
            {
                planets.Remove(planets[i]);               
            }           
        }

        if (planets.Count == 0)
        {
            completed.SetActive(true);
        }
    }
}
