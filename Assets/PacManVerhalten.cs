using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManVerhalten : MonoBehaviour {

    //Lokale Variable zum Zaehlen
    private int score;
    private float old_v, old_h;
    public float timeDelta;

	// Use this for initialization
	void Start () {
        score = 0;
        old_v = 0;
        old_h = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeDelta = 2 * Time.deltaTime;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (v < 0 && old_v == 0)
        {
            this.transform.Rotate(0, 180f, 0);
            old_v = v;
        }
        if (v > 0)
        {
            this.transform.Translate(2 * Time.deltaTime, 0, 0);
            old_v = 0;
        }
        if (v == 0) old_v = 0;

        if (h < 0 && old_h == 0)
        {
            this.transform.Rotate(0, -90f, 0);
            old_h = h;
        }
        if (h > 0 && old_h == 0)
        {
            this.transform.Rotate(0, 90f, 0);
            old_h = h;
        }
        if (h == 0) old_h = 0;

        if (this.transform.position.z < -13.5)
        {
            Vector3 pos = this.transform.position;
            pos.z = 13.5f;
            this.transform.position = pos;
        }
        if (this.transform.position.z > 13.5)
        {
            Vector3 pos = this.transform.position;
            pos.z = -13.5f;
            this.transform.position = pos;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        //Kollision mit Kapsel
        if (col.name.StartsWith("C"))
        {
            score++;
            Destroy(col.gameObject);
        }
        //Kollision mit Wand --> zurueckbewegen
        //else
        //{
        //    if (col.name.StartsWith("IR")|| col.name.StartsWith("IW")|| col.name.StartsWith("AW"))
        //    {
        //        this.transform.Translate(-3 * timeDelta, 0, 0);
        //    }
        //}
        //print("Test: " + col + " Score: " + score + " " + rot.w + " "+rot.x+" "+rot.y+" "+rot.z);
    }
};
