using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int myVariable;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ma variable est égale à : " + myVariable);
    }
}
