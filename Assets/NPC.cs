using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NPC : MonoBehaviour
{
    public UnityEvent onPlayerInteracted;

    private void Start()
    {
        if (onPlayerInteracted == null)
        {
            onPlayerInteracted = new UnityEvent();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onPlayerInteracted.Invoke();
        }
    }
}
