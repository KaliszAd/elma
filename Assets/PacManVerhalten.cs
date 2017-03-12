using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Wenn die NavMesh wege nicht vollstaendig generiert,
// bzw. gebacken werden, kann es sein, dass diese z.B.
// durch die Geister blockiert waren. Da kann die Agent
// Height angehoben werden und der Geist hochgehoben werden.
// Nach dem Backen der Wege kann man wieder den Geist
// runternehmen. Der Geist wirkt sonst als Obstacle.

public class PacManVerhalten : MonoBehaviour {

    //Lokale Variable zum Zaehlen
    private int score, totalTime;
    private float old_v, old_h, camera_angle;
    public float timeDelta;
    private GameObject mainCamera;


    // Use this for initialization
    void Start () {
        score = 0;
        old_v = 0;
        old_h = 0;
        camera_angle = 0;
        mainCamera = GameObject.Find("MainCamera");
        totalTime = 180;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //print(tex.GetHashCode());
        //GameObject.Find("Anzeige").GetComponent<Renderer>().material.mainTexture = tex;
        timeDelta = 2 * Time.deltaTime;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (camera_angle != 0)
        {
            if (camera_angle < 0)
            {
                if (camera_angle > -totalTime * timeDelta)
                {
                    mainCamera.transform.Rotate(0, camera_angle, 0);
                    camera_angle = 0;
                }
                else {
                    camera_angle += totalTime * timeDelta;
                    mainCamera.transform.Rotate(0, -totalTime * timeDelta, 0);
                }
            }
            else
            {
                if (camera_angle < totalTime * timeDelta)
                {
                    mainCamera.transform.Rotate(0, camera_angle, 0);
                    camera_angle = 0;
                }
                else
                {
                    camera_angle -= totalTime * timeDelta;
                    mainCamera.transform.Rotate(0, totalTime * timeDelta, 0);
                }
            }
        }

        //Rotation um 180 Grad
        if (v < 0 && old_v == 0)
        {
            this.transform.Rotate(0, 180f, 0);
            old_v = v;
        }
        //Bewegung nach vorn
        if (v > 0)
        {
            this.transform.Translate(2 * Time.deltaTime, 0, 0);
            old_v = 0;
        }
        if (v == 0) old_v = 0;
        //Rotation nach links
        if (h < 0 && old_h == 0)
        {
            this.transform.Rotate(0, -90f, 0);
            old_h = h;
            camera_angle -= 90;
            mainCamera.transform.Rotate(0, 90f, 0);
        }
        //Rotation nach rechts
        if (h > 0 && old_h == 0)
        {
            this.transform.Rotate(0, 90f, 0);
            old_h = h;
            camera_angle += 90;
            mainCamera.transform.Rotate(0, -90f, 0);
        }
        if (h == 0) old_h = 0;
        //Tunnel
        //if (this.transform.position.z < -10)
        //{
        //    Vector3 pos = this.transform.position;
        //    pos.z = 10.0f;
        //    this.transform.position = pos;
        //}
        //if (this.transform.position.z > 10)
        //{
        //    Vector3 pos = this.transform.position;
        //    pos.z = -10.0f;
        //    this.transform.position = pos;
        //}
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
        else
        {
            if (col.name.StartsWith("IR")|| col.name.StartsWith("IW")|| col.name.StartsWith("AW"))
            {
                this.transform.Translate(-3 * timeDelta, 0, 0);
            }
        }
        //print("Test: " + col + " Score: " + score + " " + rot.w + " "+rot.x+" "+rot.y+" "+rot.z);
    }
};
