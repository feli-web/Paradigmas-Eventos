using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelDisplay : MonoBehaviour
{
    [SerializeField]
    private LevelManager levelManager;

    [SerializeField]
    private TextMeshProUGUI levelText;

    private void OnEnable()
    {
        levelManager.onLevelChanged.AddListener(UpdateLevelText);
    }

    private void OnDisable()
    {
        levelManager.onLevelChanged.RemoveListener(UpdateLevelText);
    }

    private void UpdateLevelText(int newLevel)
    {
        levelText.text = "Level: " + newLevel;
    }
}
