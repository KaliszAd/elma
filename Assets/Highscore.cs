using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscore : MonoBehaviour {

    private List<GameItem> items;

    void readFromFile()
    {
        try {
            string[] lines = System.IO.File.ReadAllLines(@"Pac1Score.txt");
            int output = 0;
            for (int i = 0; i < lines.Length; i= i + 2)
            {
                GameItem item = new GameItem();
                item.user = lines[i];
                Int32.TryParse(lines[i + 1],out output);
                item.score = output;
                items.Add(item);
            }
        }
        catch (System.IO.FileNotFoundException e)
        {
        }
    }

    void addItem()
    {
        GameItem item = new GameItem();
        item.user = "TestUser";
        item.score = 100;
        items.Add(item);
        items.Sort();
    }

    void printItems()
    {
        GameItem item;
        for(int i = 0; i < items.Count; i++)
        {
            item = items[i];
            print(item.user + ": " + item.score);
        }
    }

    void writeToFile()
    {//Schließen des StreamWriters???
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Pac1Score.txt"))
        {
            GameItem item;
            for (int i = 0; i < items.Count; i++)
            {
                if (i == 10) break;
                item = items[i];
                file.WriteLine(item.user);
                file.WriteLine(item.score);
            }
            file.Close();
        }
    }

	// Use this for initialization
	void Start () {
        items = new List<GameItem>();
        readFromFile();
        addItem();
        printItems();
        writeToFile();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class GameItem : IComparable
{
    public string user;
    public int score;

    public int CompareTo(object obj)
    {
        GameItem go = obj as GameItem;
        return (go.score - this.score);
        throw new NotImplementedException();
    }
}