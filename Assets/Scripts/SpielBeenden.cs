using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpielBeenden : MonoBehaviour {

    private bool cleaner = false;

    public GameObject PauseCanvas;
    public GameObject Spielbrett;
    private bool paused = false;
    private bool showing = false;

    public void QuitOnClick() {

        if (cleaner)
        {
            // Registry aufräumen
            PlayerPrefs.DeleteAll();
            cleaner = false;
        }

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }

    public void verlust()
    {
        paused = true;
        Time.timeScale = 0;
        showing = true;
        PauseCanvas.SetActive(showing);
        PauseCanvas.GetComponentInChildren<Text>().text = "Verloren mit Score: " + Spielbrett.GetComponent<HighScore>().getScore().ToString() + 
            "\nund Zeit: " + Spielbrett.GetComponent<HighScore>().getGameTime().ToString() + " s";
        PauseCanvas.gameObject.transform.Find("PauseMenu").gameObject.transform.Find("Fortsetzen").gameObject.SetActive(false);
        PauseCanvas.gameObject.transform.Find("PauseMenu").gameObject.transform.Find("EingabeFeld").gameObject.SetActive(true);
    }

    public void gewinn()
    {
        if (GameObject.FindGameObjectsWithTag("Kapsel").Length == 0)
        {
            paused = true;
            Time.timeScale = 0;
            showing = true;
            PauseCanvas.SetActive(showing);
            PauseCanvas.GetComponentInChildren<Text>().text = "Gewonnen mit Score: " + Spielbrett.GetComponent<HighScore>().getScore().ToString() +
                "\nund Zeit: " + Spielbrett.GetComponent<HighScore>().getGameTime().ToString() + " s";
            PauseCanvas.gameObject.transform.Find("PauseMenu").gameObject.transform.Find("Fortsetzen").gameObject.SetActive(false);
            PauseCanvas.gameObject.transform.Find("PauseMenu").gameObject.transform.Find("EingabeFeld").gameObject.SetActive(true);
        }
    }

    public void setCleaner()
    {
        cleaner = true;
    }
}
