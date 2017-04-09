using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Unterbrechung : MonoBehaviour {


    public GameObject Spielbrett;
    public GameObject PauseCanvas;
    public GameObject StatusCanvas;
    private bool paused = false;
    private bool showing = false;

    private int temp_score;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("p") || Input.GetKeyDown("escape") == true)
        {
            if (paused == false)
            {
                paused = true;
                Time.timeScale = 0;
                showing = true;
                PauseCanvas.SetActive(showing);
            }
            else {
                fortsetzen();
            }
        }

        setScore();
	}

    public void fortsetzen() {
        showing = false;
        PauseCanvas.SetActive(showing);
        paused = false;
        Time.timeScale = 1;
    }

    public void beenden() {

            // HighScore speichern noch nachziehen
            LoadByIndex(0);
            Time.timeScale = 1;
    }

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void setScore()
    {
        temp_score = Spielbrett.GetComponent<HighScore>().getScore();
        StatusCanvas.GetComponentInChildren<Text>().text = "Score: " + temp_score.ToString();
    }

}
