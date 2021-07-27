using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerItemSlot : MonoBehaviour, IClickable
{
    
    public Sprite defaultSprite;
    public GameObject playerDisplay;
    public Item item;
    public Image itemImage;
    public CharacterInventory characterInventory;
    public GUIInventory inventoryParent;
    public EquipmentType equipmentType;

    public Sprite DefaultSprite { get => defaultSprite; }
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
    }
    void ClearSlot()
    {
        itemImage.sprite = defaultSprite;
        item = null;
    }
    public void Click()
    {
        Debug.Log("I was clicked");
        Equip();
    }
    void Equip()
    {
        Debug.Log("sadboi");
        inventoryParent.gameObject.GetComponent<EquipmentController>().Equip(Item);
        //inventoryParent.gameObject.GetComponentInChildren<CharacterSetupV2>().ReDressSprite(Item.equipmentSettings);
        inventoryParent.gameObject.GetComponentInChildren<CharacterSetupV2>().Change(Item);
        Debug.Log("sadboi");
    }

}
