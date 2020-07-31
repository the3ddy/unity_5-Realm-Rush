using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
[RequireComponent(typeof(Waypoint))]
public class CubeEditor : MonoBehaviour
{
    Vector3 gridPos;
    Waypoint waypoint;

    private void Awake()
    {
        waypoint = GetComponent<Waypoint>();
    }

    void Update()
    {
        int gridSize = waypoint.GetGridSize();
        gridPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        gridPos.y = Mathf.RoundToInt(transform.position.y / gridSize) * gridSize;
        gridPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;

        transform.position = new Vector3(gridPos.x, gridPos.y, gridPos.z);
    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
        transform.position = new Vector3(
            waypoint.GetGridPos().x,
            0f,
            waypoint.GetGridPos().y
        );
    }
}
