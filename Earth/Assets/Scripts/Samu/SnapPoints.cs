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
    
    private CoreAngle coreAngle;
    private GameObject coreTransform;

    private bool canSnap;
    private int objectsIsPlaced;
    private float snapRange = 1f, snapAngle = 20f;

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
        coreAngle = coreQuat.GetComponent<CoreAngle>();
    }


    private void Update()
    {
        if (objectsIsPlaced == originalPart.Count)
        {
            if (missionPast != missionPast.activeInHierarchy)
            {
                missionPast.SetActive(true);
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
                pos.x - copyParts[i].transform.position.x > -snapRange && pos.y - copyParts[i].transform.position.y > -snapRange)
            {
                if (CalcAngle(coreQuat, originalPart[i]))
                {
                    copyParts[i].SetActive(true);
                    //copyParts[i].transform.SetParent(GameObject.Find("Core").transform);
                    copyParts[i].transform.SetParent(coreTransform.transform);
                    //copyParts[i].transform.rotation = GameObject.Find("Core").transform.rotation;
                    copyParts[i].transform.rotation = coreTransform.transform.rotation;
                    //copyParts[i].transform.position = new Vector3(GameObject.Find("Core").transform.position.x, GameObject.Find("Core").transform.position.y);
                    copyParts[i].transform.position = new Vector3(coreTransform.transform.position.x, coreTransform.transform.position.y);
                    if (copyParts[i].tag != "IsPlaced")
                    {
                        TagTheObject(copyParts[i]);
                    }
                    originalPart[i].SetActive(false);
                    canSnap = false;
                    CursorScript.onDrag = false;
                    Cursor.visible = true;
                }
            }
        }
    }

    private bool CalcAngle(GameObject core, GameObject target)
    {
        var coreQuat = core.transform.rotation;
        var targetQuat = target.transform.rotation;
        float angleX = Quaternion.Angle(coreQuat, targetQuat);
        float angleY = Quaternion.Angle(coreQuat, targetQuat);

        if (angleX < snapAngle && angleY < snapAngle)
        {
            canSnap = true;
        }
        return canSnap;
    }

    private void TagTheObject(GameObject obj)
    {
        obj.gameObject.tag = "IsPlaced";
        objectsIsPlaced++;
    }
}

            
        
    

