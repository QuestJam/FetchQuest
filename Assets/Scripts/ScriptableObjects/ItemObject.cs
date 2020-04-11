using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : ScriptableObject
{
    [Header("Item Details")]
    public string itemName;
    public Sprite icon;
    [TextArea(2, 4)]
    public string flavourText;

    [Header("Inventory Details")]
    public int quantity;
    public int maxStackSize;

    [Header("Value Details")]
    public int itemValue;

}
