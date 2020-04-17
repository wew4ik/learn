using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
        int a = 14;
        int b = 12;
        int c = 10;
        if (a < b)
            Debug.Log("nope");
        else if (a > c)
            Debug.Log("Yep");
        else
            Debug.Log("я лох");

    }

    
    
}
