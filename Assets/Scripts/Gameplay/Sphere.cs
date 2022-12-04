using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ItemsInventory itemsInventory = other.GetComponent<ItemsInventory>();
        if(itemsInventory!=null)
        {
            itemsInventory.ItemCollected();
            gameObject.SetActive(false);
        }
    }
}
