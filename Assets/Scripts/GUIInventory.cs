using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GUIInventory : SerializedMonoBehaviour
{
    public IClickable[] slots;
    public GameObject slotsParent;
    public GameObject coins;
    private TextMeshProUGUI tmp;
    private void Awake()
    {
        slotsParent = transform.GetChild(0).gameObject;
        slots = slotsParent.GetComponentsInChildren<IClickable>();
        tmp = coins.GetComponentInChildren<TextMeshProUGUI>();
    }
    private void Start()
    {
        //DisplayItemsToGUI(seedItems);
        
    }

    public void DisplayItemsToGUI(List<Item> items)
    {
        
        for (int i = 0; i < items.Count; i++)
        {
            bool added = false;
            
            for (int s = 0; s < slots.Length; s++)
            {
                if(slots[s].Item != items[i]) 
                {
                    if (slots[s].Item == null && !added)
                    {
                        slots[s].Item = items[i];
                        slots[s].UpdateSlot();
                        added = true;
                        break;
                    }
                }
                else { break; }
                
            }
        }
        
    }

    public void UpdateCoins(int coins)
    {
        tmp.text = coins.ToString();
    }
    

}
