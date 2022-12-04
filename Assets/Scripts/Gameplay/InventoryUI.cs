using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
   
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

   public void UpdateScoreText(ItemsInventory itemsInventory)
   {
        scoreText.text = itemsInventory.NumberofItems.ToString();
   }
}
