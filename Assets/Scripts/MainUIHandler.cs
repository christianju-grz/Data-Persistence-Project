using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{

    public Text PlayerName;
    public Text BestScore;
    private string playerName;
    // Start is called before the first frame update
    void Start()
    {
        if(SettingsManager.Instance.playerName != "")
        {
            PlayerName.text = SettingsManager.Instance.playerName;
        }else
        {
            PlayerName.text = "Anonymous";
        }
        
        
       
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
