using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    //public TextMeshProUGUI register_username;
    // Start is called before the first frame update
    void Start()
    {
        CheckForOldEntry();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void NewPlayerName()
    {
        SettingsManager.Instance.playerName = GameObject.Find("Name Entry").GetComponent<TMP_InputField>().text;
        
    }

   public void CheckForOldEntry()
    {
        if(SettingsManager.Instance.playerName != null)
        {
            GameObject.Find("Name Entry").GetComponent<TMP_InputField>().text = SettingsManager.Instance.playerName;
            

        }
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
