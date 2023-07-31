using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class item : MonoBehaviour
{
    public Sprite itemSprite;
    public KeyTypes keyType;
    public enum KeyTypes
    {
        red,
        blue,
        green,
        black,
    }
}
