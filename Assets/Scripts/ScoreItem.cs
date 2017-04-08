using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class ScoreItem : IComparable<ScoreItem> {

    public int score;
    public float time;
    public string name;

    public static ScoreItem createFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<ScoreItem>(jsonString);
    }

    public string getJSON()
    {
        return JsonUtility.ToJson(this);
    }

    public int CompareTo(ScoreItem item)
    {
        return score.CompareTo(item);
    }

    //public static Comparison<ScoreItem> Comparison = delegate (ScoreItem x, ScoreItem y)
    //{
    //    return x.time.CompareTo(y.time);
    //};
}
