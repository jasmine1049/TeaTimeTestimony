using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<Item> items = new List<Item>();
    public bool debugLogInventory = false;

    public void add(Item item, int amount)
    {
        for(int i=0; i<amount; i++)
        {
            items.Add(item);
        }

        if (GameManager.Instance.shouldDebug)
        {
            Debug.Log(string.Format("ADDED ITEM: {0} {1} to the inventory", amount, item.name));

        }
        
    }

    public void remove(Item item)
    {
        items.Remove(item);
    }

    private void Update() {
        if (debugLogInventory)
        {
            debugLogInventory = false;
            Debug.Log("Current Inventory:" % Colorize.YELLOW);
            foreach (Item i in items) 
            {
                Debug.Log("\t" + i.name % Colorize.YELLOW);
            }
        }
    }
}