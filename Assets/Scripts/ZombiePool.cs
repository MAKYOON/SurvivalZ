using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePool : MonoBehaviour
{
    List<GameObject> zombiesToPool = new List<GameObject>();
    [SerializeField] GameObject zombiePrefab;
    [SerializeField] int numberOfZombies;
    PlayerController playerController;

    float timerBetweenRespawn = 5.0f;
    float xLimit = 17;
    float zLimit = 17;
    // Start is called before the first frame update

    public List<GameObject> returnPoolOfZombies()
    {
        return zombiesToPool;
    }

    public float getTimerBetweenRespawn()
    {
        return timerBetweenRespawn;
    }

    public void setTimerBetweenRespawn(float timer)
    {
        timerBetweenRespawn = timer;
    }
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        CreatePoolOfZombie();
        StartCoroutine(SpawnZombie());
    }

    void CreatePoolOfZombie()
    {
        for (int i = 0; i < numberOfZombies; i++)
        {
            GameObject zombie = Instantiate(zombiePrefab);
            zombie.transform.SetParent(GameObject.Find("ZombieSpawner").transform);
            zombie.SetActive(false);
            zombiesToPool.Add(zombie);
        }
    }

    IEnumerator SpawnZombie()
    {
        while (!playerController.isCurrentlyDead())
        {
            GameObject zombie = GetPooledZombie();
            if (zombie != null)
            {
                zombie.transform.position = new Vector3(Random.Range(-xLimit, xLimit), 0, Random.Range(-zLimit, zLimit));
                zombie.transform.rotation = Quaternion.identity;
                zombie.SetActive(true);
            }
            yield return new WaitForSeconds(timerBetweenRespawn);
        }
    }

    GameObject GetPooledZombie()
    {
        foreach (GameObject zombie in zombiesToPool)
        {
            if (!zombie.activeInHierarchy)
                return zombie;
        }
        return null;
    }
}
