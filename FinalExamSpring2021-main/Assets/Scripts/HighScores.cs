using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScores : MonoBehaviour
{
    //[System.Serializable]
    public List<HighScoreEntry> TopScores;
    //public HighScoreEntry [] TopScores;
    public HighScoreDisplay d1;
    public HighScoreDisplay d2;
    public HighScoreDisplay d3;
    public HighScoreDisplay d4;
    public HighScoreDisplay d5;
    public HighScoreDisplay d6;
    public HighScoreDisplay d7;
    public HighScoreDisplay d8;
    public HighScoreDisplay d9;
    public HighScoreDisplay d10;

    public void Start()
    {
        HighScoreEntry empty = new HighScoreEntry(0, "");
        //TopScores = LoadJSON(TopScores);

        HighScoreEntry entry = new HighScoreEntry(GameManager.score, SendText.theName);
        /*HighScoreEntry entry1 = new HighScoreEntry(10, "JJ");
        HighScoreEntry entry2 = new HighScoreEntry(101, "PIE");
        HighScoreEntry entry3 = new HighScoreEntry(1, "AAA");
        HighScoreEntry entry4 = new HighScoreEntry(100, "King");*/
        
        HighScores1 HighestScores = new HighScores1 { EntryList = TopScores};

        if (PlayerPrefs.HasKey("HighScoresTable"))
        {
            string jsonstring = PlayerPrefs.GetString("HighScoresTable");
            HighestScores = JsonUtility.FromJson<HighScores1>(jsonstring);
            Debug.Log("Loaded Scores from JSON");
        }
        //Debug.Log(jsonstring);
        
        if(HighestScores.EntryList.Count < 10)
        {
            HighestScores.EntryList.Add(entry);
        }
        else if(entry.score > HighestScores.EntryList[HighestScores.EntryList.Count - 1].score)
        {
            HighestScores.EntryList.Remove(HighestScores.EntryList[HighestScores.EntryList.Count - 1]);
            HighestScores.EntryList.Add(entry);
        }
        SortList(HighestScores.EntryList);
        //TopScores = {entry, entry1, entry2, entry3, entry4, entry5};
        /*
        HighestScores.EntryList.Add(entry);
        HighestScores.EntryList.Add(entry1);
        HighestScores.EntryList.Add(entry2);
        HighestScores.EntryList.Add(entry3);
        HighestScores.EntryList.Add(entry4);
        */
        //SortList(HighestScores.EntryList);


        SaveAsJSON(HighestScores);
        //LoadJSON(HighestScores);



        //Debug.Log(inputList.EntryList[1].name);

        
        if (HighestScores.EntryList.Count > 0)
            d1.setDisplay(HighestScores.EntryList[0]);
        else d1.setDisplay(empty);
        if (HighestScores.EntryList.Count > 1)
            d2.setDisplay(HighestScores.EntryList[1]);
        else d2.setDisplay(empty);
        if (HighestScores.EntryList.Count > 2)
            d3.setDisplay(HighestScores.EntryList[2]);
        else d3.setDisplay(empty);
        if (HighestScores.EntryList.Count > 3)
            d4.setDisplay(HighestScores.EntryList[3]);
        else d4.setDisplay(empty);
        if (HighestScores.EntryList.Count > 4)
            d5.setDisplay(HighestScores.EntryList[4]);
        else d5.setDisplay(empty);
        if (HighestScores.EntryList.Count > 5)
            d6.setDisplay(HighestScores.EntryList[5]);
        else d6.setDisplay(empty);
        if (HighestScores.EntryList.Count > 6)
            d7.setDisplay(HighestScores.EntryList[6]);
        else d7.setDisplay(empty);
        if (HighestScores.EntryList.Count > 7)
            d8.setDisplay(HighestScores.EntryList[7]);
        else d8.setDisplay(empty);
        if (HighestScores.EntryList.Count > 8)
            d9.setDisplay(HighestScores.EntryList[8]);
        else d9.setDisplay(empty);
        if (HighestScores.EntryList.Count > 9)
            d10.setDisplay(HighestScores.EntryList[9]);
        else d10.setDisplay(empty);

    }

    public void SortList(List<HighScoreEntry> Top)
    {
        int max = Top.Count;
        //int smallest;
        HighScoreEntry temp;
        for(int i = 0; i < max; i++)
        {
            for (int j = i + 1; j < max; j++)
            {
                if (Top[i].score < Top[j].score)
                {
                    temp = Top[i];
                    Top[i] = Top[j];
                    Top[j] = temp;
                }
            }
        }
    }
    
    public static void SaveAsJSON(HighScores1 TopScores)
    {
        //PlayerData data = new PlayerData(player);
        string json = JsonUtility.ToJson(TopScores);
        Debug.Log("Saving as High Scores as JSON");
        Debug.Log(json);
        PlayerPrefs.SetString("HighScoresTable", json);
        PlayerPrefs.Save();
        
    }

    public void ClearScores()
    {
        string jsonstring = PlayerPrefs.GetString("HighScoresTable");
        HighScores1 HighestScores = JsonUtility.FromJson<HighScores1>(jsonstring);
        HighestScores.EntryList.Clear();
        SaveAsJSON(HighestScores);
        GameManager.score = 0;
        SendText.theName = " ";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    [System.Serializable]
    public class HighScores1
    {
        public List<HighScoreEntry> EntryList;
    }

}
