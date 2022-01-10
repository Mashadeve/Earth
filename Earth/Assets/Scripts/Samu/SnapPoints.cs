using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SnapPoints : MonoBehaviour
{
    [SerializeField] private List<GameObject> copyParts = new List<GameObject>();
    [SerializeField] private GameObject coreQuat;
    [SerializeField] private GameObject missionPast;

    public List<GameObject> originalPart = new List<GameObject>();
    private GameObject coreTransform;
    private int objectsIsPlaced;
    private float snapRange = 1f;

    private void Awake()
    {
        coreTransform = GameObject.Find("Core");
    }


    private void Start()
    {
        for (int i = 0; i < originalPart.Count; i++)
        {
            var copy = Instantiate(originalPart[i]);
            Destroy(copy.GetComponent<PartRaycast>());
            Destroy(copy.GetComponent<Collider>());
            copy.SetActive(false);
            copyParts.Add(copy);

            
        }

        for (int i = 0; i < originalPart.Count; i++)
        {
            originalPart[i].transform.position = new Vector3(-41 + i * 15, 20);
        }
       
    }


    private void Update()
    {
        if (objectsIsPlaced == originalPart.Count)
        {
            if (missionPast != missionPast.activeInHierarchy)
            {
                missionPast.SetActive(true);
                Destroy(coreQuat.GetComponent<EarthControllerSamunScene>());
                coreQuat.AddComponent<SunRotate>();
                coreQuat.GetComponent<SunRotate>().rotationSpeed = -20;
            }
            else
            {
                return;
            }
            
        }

        for (int i = 0; i < originalPart.Count; i++)
        {
            Vector3 pos = originalPart[i].transform.position;
            
            if (pos.x - copyParts[i].transform.position.x < snapRange && pos.y - copyParts[i].transform.position.y < snapRange &&
                pos.x - copyParts[i].transform.position.x > -snapRange && pos.y - copyParts[i].transform.position.y > -snapRange &&
                CorrectAngle.canSnapNew)
            {
                copyParts[i].SetActive(true);
                copyParts[i].transform.SetParent(coreTransform.transform);
                copyParts[i].transform.rotation = coreTransform.transform.rotation;

                copyParts[i].transform.position = new Vector3(coreTransform.transform.position.x, coreTransform.transform.position.y);
                if (copyParts[i].tag != "IsPlaced")
                {
                    copyParts[i].layer = 0;
                    copyParts[i].transform.GetChild(0).gameObject.layer = 0;
                    TagTheObject(copyParts[i]);
                    CursorScript.ResetCursor();
                }
                copyParts[i].GetComponentInChildren<MeshRenderer>().material.color = PartRaycast.matColorDefault;
                originalPart[i].SetActive(false);
            }
        }
    }
    private void TagTheObject(GameObject obj)
    {
        obj.gameObject.tag = "IsPlaced";
        objectsIsPlaced++;
    }
}

            
        
    

