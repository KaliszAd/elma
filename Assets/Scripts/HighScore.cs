using System;
using System.IO;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class HighScore : MonoBehaviour {

    private int score = 0;
    private string currentPlayer;
    private float totalGameTime = 0;

    private List<ScoreItem> table;

    private void Start()
    {
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
            table.Sort();
            if (table.Count > 10)
            {
                table = table.GetRange(0, 10);
            }
            table.Sort((x, y) => x.time.CompareTo(y.time));
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

        for (int i = 0; i < 10; i++)
        {
            string jsonData = PlayerPrefs.GetString("highscore" + i);
            table.Add(ScoreItem.createFromJSON(jsonData));

            print(jsonData);
        }
    }

    public void deleteScores()
    {
        // Löscht alle einträge in Einstellungen (nicht nur HighScores)
        //PlayerPrefs.DeleteAll();
        for (int i = 0; i < 10; i++)
        {
            PlayerPrefs.DeleteKey("highscore" + i);
        }
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
