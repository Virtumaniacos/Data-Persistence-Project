using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class MainManagerMenu : MonoBehaviour
{
    public static MainManagerMenu Instance; //Si no le asignamos un valor, es “null”.

    public string playerName;
    public string bestPlayer;
    public string playerNameTable;
    public int scorePlayer = 0;
    public int scorePlayerTable = 0;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadDataPlayer();
 
    }

    [System.Serializable]
    class SaveData
    {
        public string playerName;
        public string bestPlayer;
        public string playerNameTable;
        public int  scorePlayer;
        public int scorePlayerTable;

    }
    public void SaveDataPlayer()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        data.bestPlayer = bestPlayer;
        data.playerNameTable = playerNameTable;
        data.scorePlayer = scorePlayer;
        data.scorePlayerTable = scorePlayerTable;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }


    public void LoadDataPlayer()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.playerName;
            bestPlayer = data.bestPlayer;
            playerNameTable = data.playerNameTable;
            scorePlayer = data.scorePlayer;
            scorePlayerTable = data.scorePlayerTable;

        }
    }

}
