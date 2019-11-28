using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public GameObject planeGameObject;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha5))
        {
            Destroy(planeGameObject,2f);
        }
    }
}
