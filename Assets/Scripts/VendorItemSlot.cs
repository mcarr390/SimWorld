using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VendorItemSlot : MonoBehaviour, IClickable
{
    public Sprite defaultSprite;  
    public Item item;
    public Image itemImage;
    public GUIInventory inventoryParent;

    public CharacterInventory buyerInventory;
    public CharacterInventory sellerInventory;

    public EquipmentType equipmentType;

    public Sprite DefaultSprite { get => defaultSprite;  }
    public Item Item { get => item; set => item = value; }
    public Image ItemImage { get => itemImage; }

    private void Awake()
    {     
        itemImage.sprite = defaultSprite;
        GetComponent<Button>().onClick.AddListener(this.Click);
    }
    

    public void UpdateSlot()
    {
        itemImage.sprite = item.equipmentSettings.icon;
        Debug.Log("called update slot");
    }
    void ClearSlot()
    {
        itemImage.sprite = defaultSprite;
        item = null;
    }
    public void Click()
    {
        Debug.Log("I was clicked");
        Purchase();
    }
    void Purchase()
    {
        if (buyerInventory.coins >= item.equipmentSettings.value)
        {
            Debug.Log("You can afford this: " + item.equipmentSettings.name);
            
            buyerInventory.coins -= item.equipmentSettings.value;
            buyerInventory.AddItem(item);
            sellerInventory.coins += item.equipmentSettings.value;
            sellerInventory.RemoveItem(item);
            ClearSlot();
            
        }
        else 
        {
            Debug.Log("You cannot afford this: " + item.equipmentSettings.name);
        }

    }

    
}
