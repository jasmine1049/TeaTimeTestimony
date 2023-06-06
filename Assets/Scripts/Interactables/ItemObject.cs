using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : Interactable
{
    public Item item;
    public int amount;


    override public void Interact(GameObject player)
    {
        player.GetComponent<Inventory>().add(item, amount);
    }
}

