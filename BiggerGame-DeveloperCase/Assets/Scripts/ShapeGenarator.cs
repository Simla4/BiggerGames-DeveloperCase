using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ShapeGenarator : MonoBehaviour
{
    #region Variables

    [SerializeField] private List<Triangle> triangles;
    [SerializeField] private int minTriangleCount = 2;
    [SerializeField] private int shapeCount = 5;

    #endregion

    #region Callbacks

    private void Start()
    {
        GenerateShape();
    }

    #endregion

    #region Other Methods

    private void GenerateShape()
    {
        var maksRandomVal = triangles.Count - (minTriangleCount * shapeCount);
        
        Debug.Log("first maks rnd value: " + maksRandomVal);
        
        for (int i = 1; i < shapeCount; i++)
        {
            var rnd = Random.Range(0, maksRandomVal);
            var triangleCount = rnd + 2;
            Debug.Log("triangle count of shape: " + triangleCount);
            
            maksRandomVal -= rnd;
            Debug.Log("Last maks rnd value: " + maksRandomVal);
        }

        var lastShapeTriangles = maksRandomVal + 2;
        Debug.Log("Last shape triangles:" + lastShapeTriangles);
    }

    private void DrawShape(int triangleCount)
    {
        
    }

    #endregion
}
