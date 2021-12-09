using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class MouseInput : MonoBehaviour
{
    [SerializeField] private LayerMask layermask;
    private static float3 mouseScreenPos;

    public static float2 GetScreenPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        return new float2(mousePosition.x, mousePosition.y);
    }

    public static float2 GetBoundedScreenPosition()
    {
        float2 raw = GetScreenPosition();
        return math.clamp(raw, new float2(0, 0), new float2(Screen.width - 1, Screen.height - 1));

    }

    public static float3 GetWorldPosition(Camera camera, float depth)
    {
        float2 screenPos = GetBoundedScreenPosition();
        float3 screenPosWidthDepth = new float3(screenPos, depth);
        mouseScreenPos = camera.ScreenToWorldPoint(screenPosWidthDepth);
         //tähän tarvitaan scriptin referenssi josta katsotaan peliobjektin z.positio raycastin avulla ja hiiren z.positio asetetaan samaksi
        return mouseScreenPos;
    }

    private void Update()
    {
        GetScreenPosition();
        GetBoundedScreenPosition();
        GetWorldPosition(Camera.main, 10f);
        //Debug.Log("mouseScreenPosX " + math.round(mouseScreenPos.x));
        //Debug.Log("mouseScreenPosY " + math.round(mouseScreenPos.y));
        //Ray ray = new Ray(mouseScreenPos, Vector3.forward);
        //RaycastHit hit;
        //Physics.Raycast(ray, out hit, layermask);
        //Debug.DrawRay(ray.origin, ray.direction, Color.red, 50f);

        //Debug.Log(mouseScreenPos.z);

        //if (hit.collider == null) return;
        //var thing = hit.collider.gameObject;
        //thing.GetComponent<MeshRenderer>().material.color = Color.red;
        //Debug.Log(thing);

        
    }
}
