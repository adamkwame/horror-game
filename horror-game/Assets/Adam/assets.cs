using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assets : MonoBehaviour
{
   public static assets istance { get; private set; }

    private void Awake()
    {
         istance = this;
    }
}
