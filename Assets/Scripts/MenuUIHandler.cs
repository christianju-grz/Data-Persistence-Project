using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public Color buttonActiveColor;
    public Color buttonDefaultColor;
    public Button DefaultButton;
    public Button TurboButton;
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


    public void ChangeButtonColor(Button buttonPressed)
    {
        ColorBlock cb = buttonPressed.colors;
        cb.selectedColor = buttonActiveColor;
       
        cb.pressedColor = buttonActiveColor;
        buttonPressed.colors = cb;
  

    }
    public void SetGameMode(float difficultyValue)
    {
        SettingsManager.Instance.difficulty = difficultyValue;
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
