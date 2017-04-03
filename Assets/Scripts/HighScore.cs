using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {

    private int score = 0;

    public int getScore()
    {
        return this.score;
    }

    public void incrementScore()
    {
        this.score++;
    }

}
