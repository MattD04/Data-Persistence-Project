using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string playerName;
    public int bestScore;
    public string bestPlayer;

    private void Awake() //This code enables you to access the MainManager object from any other script.  
    {
        if (Instance != null) //removes additional MainManagers that get created when moving between scenes
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); //The second line of code marks the MainManager GameObject attached to this script not to be destroyed when the scene changes.
    }

    [SerializeField]
    public void SaveData()
    {
        PlayerPrefs.SetString("BestPlayer", bestPlayer);
        PlayerPrefs.SetInt("BestScore", bestScore);
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        bestPlayer = PlayerPrefs.GetString("BestPlayer", "None");
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
    }

    public void UpdateBestScore(int score)
    {
        if (score > bestScore)
        {
            bestScore = score;
            bestPlayer = playerName;
            SaveData();
        }
    }


}
