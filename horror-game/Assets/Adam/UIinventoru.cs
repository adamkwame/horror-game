using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIinventoru : MonoBehaviour
{
    public Image[] inventorySlots;
    public bool[] isFull;
    public string[] itemName;

    public void AddItem(Sprite itemSprite, string itemName)
    {
        for (int i = 0; i < isFull.Length; i++)
        {
            if (!isFull[i])
            {
                isFull[i] = true;
                inventorySlots[i].sprite = itemSprite;
                this.itemName[i] = itemName;
                break;
            }
        }
    }
}
