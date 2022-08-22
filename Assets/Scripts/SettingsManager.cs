using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{

    public static SettingsManager Instance;
    public string playerName;
    public int lastScore;
    public float difficulty;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
        //default on load
        difficulty = 2.0f;
    }

    private void Start()
    {
        
    }

}
