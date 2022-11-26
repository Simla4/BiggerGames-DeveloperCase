using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenerotor : MonoBehaviour
{
    #region Variables

    private Mesh mesh;

    private Vector3[] vertices;
    private int[] triangles;

    [SerializeField] private int sizeX = 3;
    [SerializeField] private int sizeY = 3 ;

    [SerializeField] private MeshFilter meshFilter;

    #endregion

    #region Callbacks

    private void Start()
    {
        mesh = new Mesh();
        meshFilter.mesh = mesh;
        
        CreateShape();
        UpdateMesh();
    }

    #endregion

    #region Other Methods

    private void CreateShape()
    {
        vertices = new Vector3[]
        {
            new Vector2(0,0),
            new Vector2(0,1),
            new Vector2(1,0),
            new Vector2(1,1),
            new Vector2(0.5f, 0.5f)
        };

        triangles = new int[]
        {
            0,1,4,
            0,4,2,
            1,3,4,
            2,4,3
        };
    }

    private void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        
        mesh.RecalculateNormals();
    }

    #endregion
}
