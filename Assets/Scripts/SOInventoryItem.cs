using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory Item", menuName = "Inventory/Inventory Item")]
public class SOInventoryItem : ScriptableObject
{
  public enum ItemCategory
    {
       JunkFood, HealthyFood
    }
    public ItemCategory itemCategory;
    public Sprite itemImage;
    public string itemName;

}
