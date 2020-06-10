using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int amountToPool;
    [SerializeField] int health;
    [SerializeField] int ammoCount;
    [SerializeField] int initialAmmo;
    [SerializeField] float speedWalking;
    [SerializeField] Transform bulletSpawn;
    [SerializeField] GameObject bulletPrefabToPool;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] AudioClip fireSound;
    [SerializeField] AudioClip reloadSound;
    [SerializeField] TextMeshProUGUI ammoCountText;
    [SerializeField] Button restartButton;



    float horizontalInput;
    float verticalInput;
    bool isDead;
    float timer = 0;
    float timeBetweenShots = 0.1f;

    List<GameObject> pooledObjects = new List<GameObject>();
    Animator animator;
    Transform weaponTransform;
    AudioSource audioSource;
    Rigidbody playerRb;
    HealthBar healthBar;
    //getters 
    public int GetHealth()
    {
        return health;
    }

    public bool isCurrentlyDead()
    {
        if (isDead)
            return true;
        else
            return false;
    }

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        ammoCount = initialAmmo;
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        Cursor.visible = false;
        weaponTransform = GameObject.Find("Weapon").GetComponent<Transform>();
        healthBar = GameObject.Find("Healthbar").GetComponent<HealthBar>();
        CreatePullOfBullet();
    }
    
    private void FixedUpdate()
    {
        if (!isDead)
        {
            Move();
            SetAnimations();
            RotatePlayerTowardsMouse();
        }

    }

    void Update()
    {
        timer += Time.deltaTime;
        //we keep the muzzle flash position at the gun barrel position, and enable/disable it when needed
        muzzleFlash.transform.position = bulletSpawn.transform.position;

        //display ammoCount and put 0 while we reload
        if (ammoCount >= 0)
            ammoCountText.text = ammoCount.ToString();
        else
            ammoCountText.text = 0.ToString();

        

        //fire bullets from weapon, with the muzzle flash and sound
        if (Input.GetMouseButton(0) && !isDead && !isReloading() && ammoCount > 0)
        {
            if (timer >= timeBetweenShots)
            {
                FireBullet();
                ammoCount--;
            }

        }

        //reload if we have 0 ammo or we press R, we check that it isnt reloading and that we dont reload at max ammo
        if ((ammoCount == 0 || Input.GetKeyDown(KeyCode.R)) && !isReloading() && ammoCount != initialAmmo)
        {
            StartCoroutine(Reload());
        }
        else
            animator.ResetTrigger("isReloading");

        if (health <= 0)
        {
            isDead = true;
            animator.SetBool("isDead", true);
            restartButton.gameObject.SetActive(true);
            Cursor.visible = true;
        }
    }

    //my functions

    IEnumerator Reload()
    {
        ammoCount = -1;
        audioSource.pitch = 1.0f;
        audioSource.PlayOneShot(reloadSound, 0.5f);
        animator.SetTrigger("isReloading");
        speedWalking = 40.0f;
        yield return new WaitForSeconds(3);
        ammoCount = initialAmmo;
        speedWalking = 80.0f;
    }

    //check if we are currently reloading
    public bool isReloading()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Reload") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }

    void CreatePullOfBullet()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject bullet = Instantiate(bulletPrefabToPool);
            bullet.transform.SetParent(GameObject.Find("BulletStock").transform);
            bullet.SetActive(false);
            pooledObjects.Add(bullet);
        }
    }

    void Move()
    {
        //Movements of the character
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
        playerRb.velocity = moveDirection * speedWalking * Time.fixedDeltaTime;
    }

    void SetAnimations()
    {
        animator.SetFloat("SpeedX", horizontalInput,0.1f,Time.deltaTime);
        animator.SetFloat("SpeedZ", verticalInput,0.1f, Time.deltaTime);
    }

    void RotatePlayerTowardsMouse()
    {
        //this creates a ray from the camera to the mouse position
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //we create a virtual ground plane to intersect with the ray (facing up, placed at 0,0,0)
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        //to store the length of the ray where it intersected with the plane
        float rayLength;

        //if the ray has hit, the "out" parameter allows us to store the length where it intersected
        if (groundPlane.Raycast(cameraRay, out rayLength))
        {
            //we get the point where the ray has intersected
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));

        }
    }


    void FireBullet()
    {
        timer = 0;
        GameObject bullet = GetPooledBullet();
        if (bullet != null)
        {
            bullet.transform.position = bulletSpawn.position;
            bullet.transform.rotation = bulletSpawn.rotation;
            bullet.SetActive(true);
        }
        StartCoroutine(PlayMuzzleFlash());
        audioSource.PlayOneShot(fireSound);
        audioSource.pitch += 0.01f; 
    }

    IEnumerator PlayMuzzleFlash()
    {
        muzzleFlash.gameObject.SetActive(true);
        yield return new WaitForFixedUpdate();
        muzzleFlash.gameObject.SetActive(false);
    }

    //returns the GameObject that we are going to set active to display
    private GameObject GetPooledBullet()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }

    public void RemoveHealth()
    {
        health -= 10;
        healthBar.UpdateHealth();
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("MyScene");
    }
}

