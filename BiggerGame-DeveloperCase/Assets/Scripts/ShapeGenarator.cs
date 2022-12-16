using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ShapeGenarator : MonoBehaviour
{
    #region Variables

    [SerializeField] private List<Triangle> triangles;
    [SerializeField] private List<Transform> transformList;
    [SerializeField] private int minTriangleCount = 2;
    [SerializeField] private int shapeCount = 5;

    private int shape = 0;

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
        
        //Debug.Log("first maks rnd value: " + maksRandomVal);
        
        for (int i = 1; i < shapeCount; i++)
        {
            var rnd = Random.Range(0, maksRandomVal);
            var triangleCount = rnd + 2;
            //Debug.Log("triangle count of shape: " + triangleCount);
            
            maksRandomVal -= rnd;
            //Debug.Log("Last maks rnd value: " + maksRandomVal);
            
            DrawShape(triangleCount);
        }

        var lastShapeTriangleCount = maksRandomVal + 2;
        //Debug.Log("Last shape triangles:" + lastShapeTriangleCount);
        DrawShape(lastShapeTriangleCount);
    }

    private void DrawShape(int triangleCount)
    {
        int i = 0;
        var listCount = triangles.Count;

        while (i < triangleCount)
        {
            
            var index = Random.Range(0, listCount);
            
            Debug.Log(listCount);

            var selectedTriangle = triangles[index];

            if (selectedTriangle.isChosen == false)
            {
                triangles[index].transform.SetParent(transformList[shape]);
                triangles[index].isChosen = true;

                listCount = selectedTriangle.adjasentTriangles.Count;

                i++;
            }
        }

        shape++;
    }

    #endregion
}
