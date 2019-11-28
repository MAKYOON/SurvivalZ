using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform barrelLocation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation) as Rigidbody;
            bulletInstance.AddForce(400, 0, 0);
        }
    }
}
