using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public UnityEvent<int> onLevelChanged;

    private int currentLevel = 1;

    private void Start()
    {
        if (onLevelChanged == null)
        {
            onLevelChanged = new UnityEvent<int>();
        }

        onLevelChanged.Invoke(currentLevel);
    }

    public void ChangeLevel(int newLevel)
    {
        currentLevel = newLevel;
        onLevelChanged.Invoke(currentLevel);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChangeLevel(currentLevel + 1); 
        }
    }
}
