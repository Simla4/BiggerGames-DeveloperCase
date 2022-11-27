using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicibleObject : MonoBehaviour
{
    #region Variables

    public bool isElected = false;
    public List<SlicibleObject> neighboringObjects = new List<SlicibleObject>();

    #endregion
}
