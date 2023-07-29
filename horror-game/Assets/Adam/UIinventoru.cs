using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class UIinventoru : MonoBehaviour
{
    private inventory inventory;
    private Transform itemslotcontainer;
    private Transform itemslottemplate;

    private void Awake()
    {
        itemslotcontainer = transform.Find("itemslotcontainer");
        itemslottemplate = itemslotcontainer.Find("itemslottemplate");
    }


    public void  setinventiry(inventory inventory)
    {
        this.inventory = inventory;
        refreshinventory();
    }

    private void refreshinventory()
    {
        int x = 0;
        int y = 0;
        float itenslotcellsize = 30f;
        foreach(item item in inventory.GetItemList()) {
        RectTransform itemslotRectTransform = Instantiate(itemslottemplate, itemslotcontainer).GetComponent<RectTransform>();
        itemslotRectTransform.gameObject.SetActive(true);
            itemslotRectTransform.anchoredPosition = new Vector2(x * itenslotcellsize, y * itenslotcellsize);
            x++;
            if(x > 4)
            {
                x = 0;
                y++;
            }
        }
    }
}
