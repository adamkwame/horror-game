using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickingup : MonoBehaviour
{
    private inventory inventory;
    private void Start()
    {
      inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();  
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    break;
                }
                
            }
        }
    }
}
