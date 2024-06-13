using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TextMeshProUGUI healthText;

    private void OnEnable()
    {
        playerHealth.onHealthChanged.AddListener(UpdateHealthText);
    }

    private void OnDisable()
    { 
        playerHealth.onHealthChanged.RemoveListener(UpdateHealthText);
    }

    private void UpdateHealthText(int newHealth)
    {
        healthText.text = "Health: " + newHealth;
    }
}
