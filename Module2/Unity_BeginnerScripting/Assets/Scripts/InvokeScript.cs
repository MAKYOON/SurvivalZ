using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    public GameObject objectToInstantiate;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 2f, 2f);
    }

    // Update is called once per frame
    void SpawnObject()
    {
        Instantiate(objectToInstantiate, new Vector3(-3, 3,0),Quaternion.identity);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            CancelInvoke();
        }
    }
}
