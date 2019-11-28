using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    int myNumber = 5;
    void Start()
    {
        do
        {
            Debug.Log("Hello World");
        }
        while (myNumber != 5);
    }
  
}
