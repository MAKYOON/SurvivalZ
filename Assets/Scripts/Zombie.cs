using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Zombie : MonoBehaviour
{
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip deathSound;
    [SerializeField] AudioClip biteSound;

    GameObject canvas;
    GameObject panel;
    AudioSource audioSource;
    Transform playerTransform;
    Animator animator;
    CapsuleCollider capsuleCollider;
    PlayerController playerController;
    NavMeshAgent navmeshAgent;
    ZombiePool zombiePool;


    float rangeToAttack = 1.0f;
    float time = 0;
    float timeBetweenAttacks = 1.5f;
    float walkingSpeed = 1.0f;
    bool isDead;
    int initialHealth = 3;
    int currentHealth;


    void Start()
    {
        currentHealth = initialHealth;
        zombiePool = GameObject.Find("ZombieSpawner").GetComponent<ZombiePool>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        capsuleCollider = GetComponent<CapsuleCollider>();
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        canvas = GameObject.Find("Canvas");
        panel = canvas.transform.Find("Panel").gameObject;
        navmeshAgent = GetComponent<NavMeshAgent>();
        navmeshAgent.speed = walkingSpeed;

    }

    void Update()
    {
        //time used for keeping the zombie from attacking multiple times in a single frame
        time += Time.deltaTime;
        float distanceBetweenZombieAndPlayer = Vector3.Distance(transform.position, playerTransform.position);

        if (GameManager._instance.numberOfZombiesKilled >= 10)
        {
            animator.SetFloat("speed", 4.0f);
        }

        if (GameManager._instance.counterToIncreaseDifficulty%10 == 0 && GameManager._instance.counterToIncreaseDifficulty != 0)
        {
            GameManager.ResetCounterDifficulty();
            foreach (GameObject zombie in zombiePool.returnPoolOfZombies())
            {
                NavMeshAgent zombieNavMesh = zombie.GetComponent<NavMeshAgent>();
                zombieNavMesh.speed += 0.5f;
            }
            if (zombiePool.getTimerBetweenRespawn() > 1.5f)
                zombiePool.setTimerBetweenRespawn(zombiePool.getTimerBetweenRespawn() - 0.5f);

        }

        if (!isDead && !playerController.isCurrentlyDead())
        {
            SetDestination();
            //if it's close enough, attack but dont move any closer
            if (distanceBetweenZombieAndPlayer <= rangeToAttack)
            {
                if (time >= timeBetweenAttacks && playerController.GetHealth() > 0)
                {
                    ZombieAttack();
                    StartCoroutine(ScreenFlash());
                }
                else
                    animator.ResetTrigger("isAttacking");
            }
        }

        if (playerController.isCurrentlyDead())
        {
            animator.enabled = false;
            navmeshAgent.enabled = false;
        }
            


    }

    void SetDestination()
    {
        float distanceBetweenZombieAndPlayer = Vector3.Distance(transform.position, playerTransform.position);
        //keep looking in player's direction
        transform.LookAt(playerTransform);
        //while its far from player, keep moving towards him
        if (distanceBetweenZombieAndPlayer > rangeToAttack)
        {
            navmeshAgent.SetDestination(playerTransform.position);
        }
    }

    IEnumerator ScreenFlash()
    {
        panel.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        panel.SetActive(false);
    }

    //we reset the time (used for having a timer between attacks), play animation and remove health
    void ZombieAttack()
    {
        time = 0;
        animator.SetTrigger("isAttacking");
        audioSource.PlayOneShot(biteSound, 0.2f);
        playerController.RemoveHealth();
    }

    void TakeDamage()
    {
        currentHealth--;
        audioSource.PlayOneShot(hitSound, 0.3f);
    }

    IEnumerator ZombieDeath()
    {
        //we make it die, play the animation of death, disable collider and play sounds
        isDead = true;
        navmeshAgent.enabled = false;
        animator.SetBool("isDead", true);
        capsuleCollider.enabled = false;
        audioSource.PlayOneShot(deathSound, 0.3f);
        yield return new WaitForSeconds(2);
        //after 2 seconds, we disable it, and put it back in the pool by making it alive and re-activating its collider
        gameObject.SetActive(false);
        isDead = false;
        navmeshAgent.enabled = true;
        capsuleCollider.enabled = true;
        currentHealth = initialHealth;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage();
            if (currentHealth <= 0)
            {
                StartCoroutine(ZombieDeath());
                GameManager._instance.counterToIncreaseDifficulty++;
                GameManager._instance.numberOfZombiesKilled++;
                GameManager.UpdateTextZombiesKilled();
            }
        }

    }



}
