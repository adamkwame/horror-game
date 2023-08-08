using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pickup : MonoBehaviour
{
    public GameObject pickuptext;
    public GameObject key;
    UIinventoru uiInventory;
    public GameObject Artifact;


    void Start()
    {
        pickuptext.SetActive(false);
        uiInventory = FindObjectOfType<UIinventoru>();
        pickuptext.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && key != null)
        {
            Debug.Log("WOAHAHAHH");
            item itemScript = key.GetComponent<item>();
            uiInventory.AddItem(itemScript.itemSprite, itemScript.keyType.ToString());
            Destroy(key);
            pickuptext.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.F) && Artifact != null)
        {
            Artifact.gameObject.SetActive(false);

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
        if(other.gameObject.tag == "Artifact")
        {
            Artifact.gameObject.SetActive(true);
            Artifact= other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Debug.Log("ghhjgkjghkj");
            key = null;
            pickuptext.gameObject.SetActive(false);
        }
    }
}