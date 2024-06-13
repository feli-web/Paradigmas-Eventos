using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collectible : MonoBehaviour
{
    UnityEvent onCollected;

    private void Start()
    {
        if (onCollected == null)
        {
            onCollected = new UnityEvent();
        }

        // Encontrar el objeto del jugador y obtener el componente Inventory
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Inventory playerInventory = player.GetComponent<Inventory>();
            if (playerInventory != null)
            {
                // Suscribirse al evento onCollected
                onCollected.AddListener(playerInventory.AddItem);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onCollected.Invoke();

            Destroy(gameObject);
        }
    }
}
