using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ShapeGenerator : MonoBehaviour
{
    #region Variables

    [SerializeField] private Rigidbody2D rb;

    private float posX;
    private float posY;

    #endregion

    #region Callbacks

    private void Start()
    {
        var rndX = Random.Range(0, 7);
        posX = rndX / 2;

        var rndY = Random.Range(0, 7);
        posY = rndY / 2;

        transform.localPosition = new Vector3(posX, posY, 0);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Slicable"))
        {
            Debug.Log(col.gameObject.name);
        }
    }

    #endregion

    #region Other Methods



    #endregion
}
