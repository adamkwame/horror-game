using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperInteraction : MonoBehaviour
{
    [SerializeField] private GameObject noteImage;

    private void Start()
    {
        noteImage.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            noteImage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            noteImage.SetActive(false);
        }
    }
}
