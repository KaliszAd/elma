using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class NameInput : MonoBehaviour {

    public InputField inputName;
    private string playerName;
    //private InputField EingabeFeld;

    public void setPlayerName()
    {
        this.playerName = inputName.text;
        print(playerName);
    }

    public string getPlayerName()
    {
        return this.playerName;
    }
}
