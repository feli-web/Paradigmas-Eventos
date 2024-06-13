using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public UnityEvent<int> onHealthChanged;

    private void Start()
    {
        onHealthChanged = new UnityEvent<int>();
        

        onHealthChanged.Invoke(health);
    }

    // Método para modificar la salud
    public void ChangeHealth(int amount)
    {
        health += amount;
        onHealthChanged.Invoke(health);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChangeHealth(1); 
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChangeHealth(-1); 
        }
    }
}
