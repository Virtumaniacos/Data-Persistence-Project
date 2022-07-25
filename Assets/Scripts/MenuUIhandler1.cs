using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUIhandler1 : MonoBehaviour
{
    public TMP_InputField inputField;

    public void playerNameGetter(string name)
    {
        name = inputField.text;
        MainManagerMenu.Instance.playerName = name;
    }
    
    private void Start()
    {
        inputField.text = MainManagerMenu.Instance.playerName;
    }


    public void StartNew()
    {
        playerNameGetter(name);
        SceneManager.LoadScene(1);
    }

    public void ScoreTableScene()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        MainManagerMenu.Instance.SaveDataPlayer();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
            Application.Quit(); // original code to quit Unity player
#endif
    }

    public void ExitToScene0()
    {
        SceneManager.LoadScene(0);
    }
}
