using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class item 
{
   public enum itemtype
    {
        key,
        pill,
        atrifact,
    }
    public itemtype Itemtype;
    public int amount;

   /* public Sprite GetSprite()
    {
        switch (Itemtype) {
            default:
                case temtype.key:
        }
    }*/
}
