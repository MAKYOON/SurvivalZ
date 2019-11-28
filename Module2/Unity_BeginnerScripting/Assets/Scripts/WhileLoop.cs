using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int myNumber = 5;
    // Start is called before the first frame update
    void Start()
    {
        while (myNumber>=0)
        {
            Debug.Log("Décompte : " + myNumber);
            myNumber--;
        }
    }
}
