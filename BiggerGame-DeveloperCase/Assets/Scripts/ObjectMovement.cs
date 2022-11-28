using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectMovement : MonoBehaviour
{
    #region Variables

    private Vector3 objectPos;

    #endregion

    #region Other Methods

    private void OnMouseDown()
    {
        objectPos = Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDrag()
    {
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);

        transform.position = Camera.main.WorldToScreenPoint(pos);
    }

    #endregion

}
