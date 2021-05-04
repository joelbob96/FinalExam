using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public List<string> List1;
    public void SaveP()
    {
        PlayerPrefs.SetString("PlayerName", SendText.theName);
        PlayerPrefs.SetInt("Score", GameManager.score);
        PlayerPrefs.SetInt("Lives", GameManager.lives);
        PlayerPrefs.SetFloat("Time", GameManager.time);
    }

    public void LoadP()
    {
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            SendText.theName = PlayerPrefs.GetString("PlayerName");
        }
        if (PlayerPrefs.HasKey("Score"))
        {
            GameManager.score = PlayerPrefs.GetInt("Score");
        }
        if (PlayerPrefs.HasKey("Lives"))
        {
            GameManager.lives = PlayerPrefs.GetInt("Lives");
        }
        if (PlayerPrefs.HasKey("Time"))
        {
            GameManager.time = PlayerPrefs.GetFloat("Time");
        }
    }

    public void SaveAsJson()
    {
        //string jsonString = SendText.theName + ", " + GameManager.score.ToString() + ", " + GameManager.lives.ToString() + ", " + GameManager.time.ToString();
        // Debug.Log(jsonString);
        JsonSave Save1 = new JsonSave { Saved = List1};
        Save1.Saved.Add(SendText.theName);
        Save1.Saved.Add(GameManager.score.ToString());
        Save1.Saved.Add(GameManager.lives.ToString());
        Save1.Saved.Add(GameManager.time.ToString());
        string json = JsonUtility.ToJson(Save1);
        Debug.Log(json);
    }

    [System.Serializable]
    public class JsonSave{
        public List<string> Saved;
    };
}
