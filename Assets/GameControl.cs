using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpielBeenden : MonoBehaviour {

    public Button stop;
    public Button start;

	// Use this for initialization
	void Start () {
        Button stopButton = stop.GetComponent<Button>();
        stopButton.onClick.AddListener(StopOnClick);
        Button startButton = start.GetComponent<Button>();
        startButton.onClick.AddListener(StartOnClick);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void StopOnClick()
    {
        Application.Quit();
    }

    void StartOnClick()
    {
        SceneManager.LoadScene("OriginalField");
    }
}
