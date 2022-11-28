using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region Variables

    private int currentLevel;

    #endregion

    #region Other Methods 

    private void Start()
    {
        PlayerPrefs.SetInt("CurrentLevel", 0);
    }

    private void NextLevel()
    {
        currentLevel = PlayerPrefs.GetInt("CurrentLevel", 0) + 1;
        
        if (currentLevel % 3 == 0)
        {
            currentLevel = 0;
        }
        
        PlayerPrefs.SetInt("CurrentLevel", currentLevel);
        
        EventManager.OnNextLevel?.Invoke(currentLevel);
    }

    #endregion
}
