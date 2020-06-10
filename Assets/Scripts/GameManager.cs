using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance { get; private set; }
    public int numberOfZombiesKilled;
    public int counterToIncreaseDifficulty;
    [SerializeField]
    TextMeshProUGUI zombiesKilledCountText;
    // Start is called before the first frame update
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }
        
    public static void UpdateTextZombiesKilled()
    {
        _instance.zombiesKilledCountText.text = "Zombies Killed : " + _instance.numberOfZombiesKilled;
    }

    public static void ResetCounterDifficulty()
    {
        _instance.counterToIncreaseDifficulty = 0;
    }
}
