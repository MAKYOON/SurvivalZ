using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableComponent : MonoBehaviour
{
    private Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if ((Input.GetKeyUp(KeyCode.Alpha3)))
        {
            myLight.enabled = false;
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            gameObject.SetActive(false);
        }
    }
}
