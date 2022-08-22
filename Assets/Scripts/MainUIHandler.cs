using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{

    public Text PlayerName;
    private string playerName;
    // Start is called before the first frame update
    void Start()
    {
        PlayerName.text = SettingsManager.Instance.playerName;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
