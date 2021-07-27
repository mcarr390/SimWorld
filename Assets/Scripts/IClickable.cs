using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IClickable 
{
    public void Click();
    public void UpdateSlot();
    public Sprite DefaultSprite { get; }
    public Item Item { get; set; }
    public Image ItemImage { get; }
    
}
