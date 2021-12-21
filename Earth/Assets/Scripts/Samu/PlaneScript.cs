using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlaneScript
{
    public static GameObject CreatePlane(float width, float height, Material mat)
    {
        GameObject plane = new GameObject("Bounds");
        MeshFilter mf = plane.AddComponent(typeof(MeshFilter)) as MeshFilter;
        MeshRenderer mr = plane.AddComponent(typeof(MeshRenderer)) as MeshRenderer;

        Mesh mesh = new Mesh();
        mesh.vertices = new Vector3[]
        {
            new Vector3(0,0,0),
            new Vector3(width,0,0),
            new Vector3(width, height,0),
            new Vector3(0,height,0)
        };
        mesh.uv = new Vector2[]
        {
            new Vector2(0,0),
            new Vector2(0,1),
            new Vector2(1,1),
            new Vector2(1,0)
        };
        mesh.triangles = new int[] { 0, 1, 2, 0, 2, 3 };

        mf.mesh = mesh;
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
        plane.GetComponent<MeshRenderer>().material = mat;

        return plane;
    }
}
