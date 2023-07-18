using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject pickuptext;
    public GameObject key;
    void Start()
    {
        key.SetActive(false);
        pickuptext.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            pickuptext.SetActive(true);

            if (Input.GetKey(KeyCode.F))
            {
                this.gameObject.SetActive(false);
                key.SetActive(true);
                pickuptext.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        pickuptext.SetActive(false);
    }

}
