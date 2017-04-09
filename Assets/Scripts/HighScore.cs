using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class HighScore : MonoBehaviour {

    private int score = 0;
    private string currentPlayer;
    private float totalGameTime = 0;

    private List<ScoreItem> table;
    public GameObject HighScoreMenu;

    private void Start()
    {
        // Initialize Unity way
        table = new List<ScoreItem>();
        loadScore();
    }

    private void Update()
    {
        totalGameTime = Time.time;
    }

    public void addScoreItem()
    {
        // Add Score to List
        ScoreItem item = new ScoreItem();
        // Must be set from elsewhere before saving
        item.name = this.currentPlayer;
        item.score = this.score;
        item.time = this.totalGameTime;

        table.Add(item);
    }

    public void saveScore()
    {

        if (table.Count > 1)
        {
            // Sortiere nach score, sortiere nach time wenn Übereinstimmung von score
            // Lösche überflüssige Elemente
            //table.Sort();
            // Elegantes sortieren: http://stackoverflow.com/questions/289010/c-sharp-list-sort-by-x-then-y
            table.Sort(delegate (ScoreItem b, ScoreItem a)
            {
                int z = a.score.CompareTo(b.score);
                if (z != 0) return z;
                else return a.time.CompareTo(b.time);
            });
            if (table.Count > 10)
            {
                table = table.GetRange(0, 10);
            }
            // Anonyme (lambda) Funktionen sind nicht mehr notwendig
            //table.Sort((x, y) => x.time.CompareTo(y.time));
        }

        for (int i = 0; i < table.Count; i++)
        {
            
            string jsonData = table[i].getJSON();
            print(jsonData);

            try
            {
                PlayerPrefs.SetString("highscore" + i, jsonData);
                PlayerPrefs.Save();
            }
            catch (System.Exception err)
            {
                Debug.Log("Error: " + err);
            }
        }
    }

    public void loadScore(){

        // Pruefen ob highscore vorhanden ist?
        int i = 0;
        while (PlayerPrefs.HasKey("highscore" + i) == true)
        {
            string jsonData = PlayerPrefs.GetString("highscore" + i);
            table.Add(ScoreItem.createFromJSON(jsonData));
            i++;
            print(jsonData);
        }
    }

    public void deleteScores()
    {
        // Pruefen ob highscore vorhanden ist?
        int i = 0;
        while (PlayerPrefs.HasKey("highscore" + i) == true)
        {
            PlayerPrefs.DeleteKey("highscore" + i);
            i++;
        }
    }

    public void displayScore()
    {
        string temp_string = "";
        foreach (var item in table) {
            temp_string = temp_string + item.name + " hat " + item.score + " Punkte in " + item.time + " s erlangt.\n"; 
        }
        HighScoreMenu.GetComponent<Text>().text = temp_string; 
    }

    public void setScore(string playerName)
    {
        this.currentPlayer = playerName;
        print(currentPlayer + ", " + score + ", " + totalGameTime);
        addScoreItem();
    }

    public int getScore()
    {
        return this.score;
    }

    public void incrementScore()
    {
        this.score++;
    }

    public float getGameTime()
    {
        return this.totalGameTime;
    }
}
