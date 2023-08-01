using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pickup : MonoBehaviour
{
    public GameObject pickuptext;
    public GameObject key;
    public TextMeshProUGUI Prompt;
    UIinventoru uiInventory;


    void Start()
    {
        pickuptext.SetActive(false);
        uiInventory = FindObjectOfType<UIinventoru>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && key != null)
        {
            Debug.Log("WOAHAHAHH");
            item itemScript = key.GetComponent<item>();
            uiInventory.AddItem(itemScript.itemSprite, itemScript.keyType.ToString());
            Destroy(key);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            print("Key detected");
            pickuptext.gameObject.SetActive(true);
            key = other.gameObject;
            Debug.Log("collision");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            pickuptext.gameObject.SetActive(false);
            Debug.Log("ghhjgkjghkj");
            key = null;
        }
    }
}