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
    private long temp_score;

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

        getScore();
	}

    public void fortsetzen() {
        showing = false;
        PauseCanvas.SetActive(showing);
        paused = false;
        Time.timeScale = 1;
    }

    public void beenden() {

        // Nur deaktiviert, wenn verloren
        if (PauseCanvas.gameObject.transform.Find("PauseMenu").gameObject.transform.Find("Fortsetzen").gameObject.activeInHierarchy == false)
        {
            LoadByIndex(0);
            //paused = false;
            Time.timeScale = 1;
            //showing = false;
            //PauseCanvas.SetActive(showing);
        }
        else {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
    }

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void getScore()
    {
        temp_score = Spielbrett.GetComponent<HighScore>().score;
        StatusCanvas.GetComponentInChildren<Text>().text = "Score: " + temp_score.ToString();

    }

}
