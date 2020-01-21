using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSight : MonoBehaviour
{
    LineRenderer lineRenderer;
    PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.forward,out hit))
        {
            if (!playerController.isReloading())
            {
                lineRenderer.enabled = true;
                if (hit.collider)
                {
                    lineRenderer.SetPosition(1, new Vector3(0, 0, hit.distance));
                }
                else
                    lineRenderer.SetPosition(1, new Vector3(0, 0, 500));
            }
            else
            {
                lineRenderer.enabled = false;
            }
        }

    }
}
