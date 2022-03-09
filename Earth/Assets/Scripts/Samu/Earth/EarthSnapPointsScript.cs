using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EarthSnapPointsScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> continentCopies = new List<GameObject>();
    [SerializeField] private GameObject coreQuat;
    [SerializeField] private GameObject missionPast;
    [SerializeField] private GameObject earthCoreTransform;

    public List<GameObject> originalContinents = new List<GameObject>();
    
    private int objectsIsPlaced;
    private float snapRange = 0.3f;

    private void Start()
    {
        for (int i = 0; i < originalContinents.Count; i++)
        {
            var copy = Instantiate(originalContinents[i]);
            Destroy(copy.GetComponent<MoveContinent>());
            Destroy(copy.GetComponent<Collider>());
            copy.SetActive(false);
            continentCopies.Add(copy);

            
        }

        for (int i = 0; i < originalContinents.Count; i++)
        {
            originalContinents[i].transform.position = new Vector3(-3.8f + i * 1.5f, 1.8f);
        }
       
    }


    private void Update()
    {
        if (objectsIsPlaced == originalContinents.Count)
        {
            if (missionPast != missionPast.activeInHierarchy)
            {
                missionPast.SetActive(true);
                Destroy(coreQuat.GetComponent<EarthControllerHorizontalMove>());
                coreQuat.AddComponent<SunRotate>();
                coreQuat.GetComponent<SunRotate>().rotationSpeed = -20;
            }
            else
            {
                return;
            }
            
        }

        for (int i = 0; i < originalContinents.Count; i++)
        {
            Vector3 pos = originalContinents[i].transform.position;
            
            if (pos.x - continentCopies[i].transform.position.x < snapRange && pos.y - continentCopies[i].transform.position.y < snapRange &&
                pos.x - continentCopies[i].transform.position.x > -snapRange && pos.y - continentCopies[i].transform.position.y > -snapRange &&
                CorrectAngle.canSnapNew)
            {
                continentCopies[i].SetActive(true);
                continentCopies[i].transform.SetParent(earthCoreTransform.transform);
                continentCopies[i].transform.rotation = earthCoreTransform.transform.rotation;

                continentCopies[i].transform.position = new Vector3(earthCoreTransform.transform.position.x, earthCoreTransform.transform.position.y);
                if (continentCopies[i].tag != "IsPlaced")
                {
                    continentCopies[i].layer = 0;
                    continentCopies[i].transform.GetChild(0).gameObject.layer = 0;
                    TagTheObject(continentCopies[i]);
                    CursorScript.ResetCursor();
                }
                continentCopies[i].GetComponentInChildren<MeshRenderer>().material.color = MoveContinent.matColorDefault;
                originalContinents[i].SetActive(false);
            }
        }
    }
    private void TagTheObject(GameObject obj)
    {
        obj.gameObject.tag = "IsPlaced";
        objectsIsPlaced++;
    }
}

            
        
    

