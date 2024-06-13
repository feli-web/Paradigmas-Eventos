using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int item = 0;
    public TextMeshProUGUI itemText;

    public void AddItem()
    {
        item++;
        itemText.text = "Coins: " + item.ToString("D3");
    }
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x * 2, 0, 0);  
    }
}
