using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour
{ 
    public Text ScoreDisplay;
    public Text NameDisplay;

    public void setDisplay(HighScoreEntry HS)
    {
        if (HS.score > 0)
            ScoreDisplay.text = HS.score.ToString();
        else ScoreDisplay.text = "";

        NameDisplay.text = HS.name;
    }
    public void Start()
    {
        //HighScoreEntry entry = new HighScoreEntry(WordManager.score, SendText.theName);
        //setDisplay(entry);
    }
}
