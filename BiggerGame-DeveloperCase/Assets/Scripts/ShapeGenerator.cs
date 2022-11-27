using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ShapeGenerator : MonoBehaviour
{
    #region Variables

    [SerializeField] private List<SlicibleObject> slicibleObjectsList = new List<SlicibleObject>();
    [SerializeField] private List<LevelData> levelDataList;
    [SerializeField] private List<Transform> newParent;

    #endregion

    #region Callbacks

    private void Start()
    {
        CreateShape();
    }

    #endregion

    #region Other Methods

    private void CreateShape()
    {
        var minTriangleCount = levelDataList[0].minTriangleCount;
        var shapeCount = levelDataList[0].shapeCount;

        int i = 0;

        while (i < (shapeCount - 1))
        {
            var selectedTriangleIndex = Random.Range(0, slicibleObjectsList.Count);
            var selectedTriangle = slicibleObjectsList[selectedTriangleIndex];

            if (selectedTriangle.isElected == false)
            {
                slicibleObjectsList[selectedTriangleIndex].transform.parent = newParent[0].parent;
                selectedTriangle.isElected = true;
            
            
                var rnd = Random.Range(0, (36 - minTriangleCount));
                var shapeTriangleCount = minTriangleCount + rnd;

                i++;

                var newParentIndex = 0;

                int j = 0;
                while (j < shapeTriangleCount)
                {
                    var neighborObjectsCount = selectedTriangle.neighboringObjects.Count;
                
                    var newTriangleIndex = Random.Range(0, neighborObjectsCount);
                    var newTriangle = selectedTriangle.neighboringObjects[newTriangleIndex];

                    if (newTriangle.isElected == false)
                    {
                        newTriangle.transform.parent = newParent[newParentIndex];
                        newTriangle.isElected = true;

                        selectedTriangle = newTriangle;

                        slicibleObjectsList.Remove(selectedTriangle);

                        j++;
                    }
                }

                newParentIndex++;
            }
            
        }

        for (int k = 0; i < slicibleObjectsList.Count; i++)
        {
            slicibleObjectsList[k].transform.parent = newParent[newParent.Count - 1];
        }
    }

    #endregion
}
