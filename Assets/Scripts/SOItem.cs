using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class SOItem : ScriptableObject  
{
    public int happinessAmount;
    public int hungerAmount;
    public bool isHappy;
    public int price;
    public Sprite icon;
    public string nameItem;

    private void OnValidate()
    {
        nameItem = name;
    }
}
