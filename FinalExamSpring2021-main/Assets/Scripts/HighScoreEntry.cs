using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class HighScoreEntry
{
        public int score;
        public string name;
        //public Text scoreDisplay;
        //public Text nameDisplay;

        public HighScoreEntry(int _score, string _name)
    {
        score = _score;
        name = _name;
    }

    /*public void DisplayScore()
    {
        scoreDisplay.text = score.ToString();
        nameDisplay.text = name;
    }*/
}
