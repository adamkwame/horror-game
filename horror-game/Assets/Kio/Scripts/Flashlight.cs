using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;

    public bool lightOn;
    public bool lightOff;
    // Start is called before the first frame update
    void Start()
    {
        lightOff = true;
        flashlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(lightOff && Input.GetKeyDown(KeyCode.F))
        {
            flashlight.SetActive(true);
            lightOff = false;
            lightOn = true;
        }

        else if (lightOn && Input.GetKeyDown(KeyCode.F))
        {
            flashlight.SetActive(false);
            lightOff = true;
            lightOn = false;
        }
    }
}
