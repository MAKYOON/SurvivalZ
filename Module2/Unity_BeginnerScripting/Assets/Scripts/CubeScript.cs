using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    int myMass = 100;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            changeMass();
        }
        if (GetComponent<Rigidbody>().mass == 100)
        {
            GetComponent<Collider>().enabled = false;
        }

    }

    void changeMass()
    {
        GetComponent<Rigidbody>().mass = myMass;
    }
    void OnMouseDown()
    {
        Debug.Log("Test");
    }
}
