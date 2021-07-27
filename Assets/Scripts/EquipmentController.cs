using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentController : MonoBehaviour
{
    public GameObject equipmentSlotParent;
    public Dictionary<EquipmentType, PlayerItemSlot> equipmentSlots;
    public GameObject player;
    private void Awake()
    {
        equipmentSlots = new Dictionary<EquipmentType, PlayerItemSlot>();

        var slots = equipmentSlotParent.GetComponentsInChildren<PlayerItemSlot>();
        equipmentSlots.Add(EquipmentType.Head, slots[0]);
        equipmentSlots.Add(EquipmentType.Chest, slots[1]);
        equipmentSlots.Add(EquipmentType.Pants, slots[2]);
        equipmentSlots.Add(EquipmentType.Feet, slots[3]);

    }
    public void Equip(Item itemToEquip)
    {
        var itemSlot = equipmentSlots[itemToEquip.equipmentSettings.equipmentType];
        itemSlot.item = itemToEquip;
        itemSlot.itemImage.sprite = itemToEquip.equipmentSettings.icon;

        player.GetComponent<CharacterSetupV2>().Change(itemToEquip);
    }

}
