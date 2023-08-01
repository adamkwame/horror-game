using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string keyRequired;
    public bool playerDetected;
    UIinventoru uiInventory;

    private void Start()
    {
        uiInventory = FindObjectOfType<UIinventoru>();  
    }

    private void Update()
    {
        if (playerDetected && Input.GetKeyDown(KeyCode.K))
        {
            for (int i = 0; i < uiInventory.itemName.Length; i++)
            {
                if (uiInventory.itemName[i] == keyRequired)
                {
                    uiInventory.itemName[i] = null;
                    uiInventory.isFull[i] = false;
                    uiInventory.inventorySlots[i].sprite = null;
                    Destroy(gameObject);
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerDetected= true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerDetected = false;
        }
    }
}
