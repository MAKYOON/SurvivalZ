using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int myNumber = 3;

    void Start()
    {
        for (int i=0;i<=myNumber;i++)
        {
            Debug.Log("Comptons jusqu'à 3 : " + i);
        }
    }


}
