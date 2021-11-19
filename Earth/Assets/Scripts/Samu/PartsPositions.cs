using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsPositions : MonoBehaviour
{
    [SerializeField] private List<GameObject> parts = new List<GameObject>();
    [SerializeField] private List<Transform> partsSolvedPositions = new List<Transform>();

    private void Start()
    {
        for (int i = 0; i < parts.Count; i++)
        {
            partsSolvedPositions.Add(parts[i].transform);
            parts[i].AddComponent<Move3D>();
        }
    }

    private void Update()
    {
        var partPos = parts[8].transform.position;
        var solvedPos = partsSolvedPositions[8].position;

        var distance = Vector3.Distance(partPos, solvedPos);
        Debug.Log(distance);
    }
}
