using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SnapPoints : MonoBehaviour
{
    [SerializeField] private List<GameObject> copyParts = new List<GameObject>();
    [SerializeField] private List<GameObject> originalPart = new List<GameObject>();
    [SerializeField] private GameObject coreQuat;
    private CoreAngle coreAngle;
    private bool canSnap;


    private void Start()
    {
        Enumerable.Range(-45, 10);

        for (int i = 0; i < originalPart.Count; i++)
        {
            var copy = Instantiate(originalPart[i]); //, new Vector3(originalPart[i].transform.position.x, originalPart[i].transform.position.y, originalPart[i].transform.position.z), Quaternion.identity);
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
        
        
        //Debug.Log("Core " + coreQuat.transform.localRotation);
        //Debug.Log("Piece " + GameObject.Find("Asia").transform.rotation.x);
        //Debug.Log("Core " + GameObject.Find("Core").transform.rotation.x);


        for (int i = 0; i < originalPart.Count; i++)
        {
            Vector3 pos = originalPart[i].transform.position;
            Debug.Log("Angle " + CalcAngle(coreQuat, originalPart[i]));
            if (pos.x - copyParts[i].transform.position.x < 0.5f && pos.y - copyParts[i].transform.position.y < 0.5f && pos.x - copyParts[i].transform.position.x > -0.5f && pos.y - copyParts[i].transform.position.y > -0.5f)
            {
                
                //if (originalPart[i].GetComponent<CoreAngle>().angle == coreAngle.angle)
                if (CalcAngle(coreQuat, originalPart[i]))
               {
                    //var offset = copyParts[i].transform.position;
                    //originalPart[i].transform.position = copyParts[i].transform.position;
                    copyParts[i].SetActive(true);
                    copyParts[i].transform.SetParent(GameObject.Find("Core").transform);
                    copyParts[i].transform.rotation = GameObject.Find("Core").transform.rotation;
                    copyParts[i].transform.position = new Vector3(GameObject.Find("Core").transform.position.x, GameObject.Find("Core").transform.position.y);
                    originalPart[i].SetActive(false);
                    canSnap = false;
                    
                }
                //originalPart.Remove(originalPart[i]);
            }
        }
    }
    
    private bool CalcAngle(GameObject core, GameObject target)
    {
        var coreQuat = core.transform.rotation;
        var targetQuat = target.transform.rotation;
        float angleX = Quaternion.Angle(coreQuat, targetQuat);
        float angleY = Quaternion.Angle(coreQuat, targetQuat);
        //float angle = Quaternion.Angle(transform.rotation, target.rotation);
        if (angleX < 10 && angleY < 10)
        {
            canSnap = true;
        }
        return canSnap;
    }
}
    //private void LateUpdate()
    //{


    //            //Destroy(originalPart[i]);

    //            //var part = Instantiate(originalPart[i], new Vector3(copyParts[i].transform.position.x, copyParts[i].transform.position.y, originalPart[i].transform.position.z), Quaternion.identity);
    //            //Destroy(part.GetComponent<PartRaycast>());
    //            //part.transform.SetParent(GameObject.Find("Core").transform);
    //            //Destroy(part.GetComponent<Collider>());
    //            //Destroy(originalPart[i]);
    //            //originalPart.Remove(originalPart[i]);
    //            //snapPoints[i].transform.position = snapPointsCurrent[i];
    //            //Destroy(snapPoints[i].GetComponent<Collider>());
    //            //snapPoints[i].transform.SetParent(GameObject.Find("Core").transform);
    //            //snapPoints.Remove(snapPoints[i]);

            
        
    

