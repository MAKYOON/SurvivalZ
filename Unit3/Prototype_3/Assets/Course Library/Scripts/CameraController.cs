using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    private AudioSource audioSource;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        audioSource = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.gameOver == true)
        {
            audioSource.Stop();
        }
    }
}
