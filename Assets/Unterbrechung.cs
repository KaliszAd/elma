using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unterbrechung : MonoBehaviour {

    public GameObject PauseCanvas;
    private bool paused = false;
    private bool showing = false;

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
	}

    public void fortsetzen() {
        showing = false;
        PauseCanvas.SetActive(showing);
        paused = false;
        Time.timeScale = 1;
    }

    public void beenden() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
