using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    [SerializeField]
    private List<Item> items;
    public GUIInventory gUIInventory;

    public int coins = 100;
    private void Start()
    {
        UpdateItemsAndCoins();
    }

    private void UpdateItemsAndCoins()
    {
        gUIInventory.DisplayItemsToGUI(items);
        gUIInventory.UpdateCoins(coins);
    }
    public void AddItem(Item item)
    {
        
        if (!items.Contains(item)) {
            items.Add(item);
            UpdateItemsAndCoins();
        }
        else { Debug.Log(" you allready have this item!"); }
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
        UpdateItemsAndCoins();

    }

}
