using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class NameInput : MonoBehaviour {

    public GameObject Spielbrett;

    public InputField inputName;
    private string playerName;

    public void setPlayerName()
    {
        this.playerName = inputName.text;
        Spielbrett.GetComponent<HighScore>().setScore(playerName);
        Spielbrett.GetComponent<HighScore>().saveScore();
    }

    public string getPlayerName()
    {
        return this.playerName;
    }
}
