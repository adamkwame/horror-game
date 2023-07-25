using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;
using TMPro;

public class pickup : MonoBehaviour
{
    public GameObject pickuptext;
    public GameObject key;

    GameObject interactedObj;

    public TextMeshProUGUI Prompt;

    private bool inRange = false;
    private bool doneSomething = false;

    private inventory inventory;
   
      
   
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
        pickuptext.SetActive(false);
    }

    private void Update()
    {
        if (inRange)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                Debug.Log("WOAHAHAHH");
                doneSomething= true;
                inRange = false;

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            inRange = true;
            Debug.Log("collision");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (doneSomething && other.gameObject.tag == "Key")
        {
           // other.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Debug.Log("ghhjgkjghkj");
           /* for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                }

            }*/
        }
    }
}