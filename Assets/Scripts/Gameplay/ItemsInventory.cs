using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemsInventory : MonoBehaviour
{
   public int NumberofItems{get;private set;}
    public UnityEvent<ItemsInventory> OnItemCollected;

   public void ItemCollected()
   {
        NumberofItems++;
        OnItemCollected.Invoke(this);
   }
}
