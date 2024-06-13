using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI dialogueText;

    private void OnEnable()
    {
        var npcs = Object.FindObjectsByType<NPC>(FindObjectsSortMode.None);
        foreach (var npc in npcs)
        {
            npc.onPlayerInteracted.AddListener(ShowDialogue);
        }
    }

    private void OnDisable()
    {
        var npcs = Object.FindObjectsByType<NPC>(FindObjectsSortMode.None);
        foreach (var npc in npcs)
        {
            npc.onPlayerInteracted.RemoveListener(ShowDialogue);
        }
    }

    private void ShowDialogue()
    {
        dialogueText.text = "Hello, square!";
    }
}
