using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreation : MonoBehaviour
{
    public GameObject wuerfel;

    // Use this for initialization
    void Start ()
    {
        //Erstelle Innenwaende
        Vector3 pos;
        float i;
        var rot = new Quaternion();
        for (i = 3.5f; i <= 6.5; i++)
        {
            pos = new Vector3(i, 0.2f, 0);
            Instantiate(wuerfel, pos, rot);
        }
        for (i = 9.5f; i <= 12.5; i++)
        {
            pos = new Vector3(i, 0.2f, 0);
            Instantiate(wuerfel, pos, rot);
        }
        for (i = -8.5f; i <= -5.5; i++)
        {
            pos = new Vector3(i, 0.2f, 0);
            Instantiate(wuerfel, pos, rot);
        }
        for (i = 1; i <= 3; i++)
        {
            pos = new Vector3(3.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(3.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(-8.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(-8.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(9.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(9.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
        }
        for (i = 3; i <= 5; i++)
        {
            pos = new Vector3(-5.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(-5.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
        }
        for (i = 3; i <= 6; i++)
        {
            pos = new Vector3(-12.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(-12.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(-11.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(-11.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(6.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(6.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
        }
        for (i = 3; i <= 11; i++)
        {
            pos = new Vector3(12.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(12.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
        }
        for (i = 9; i <= 11; i++)
        {
            pos = new Vector3(-12.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(-12.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(-11.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(-11.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(-8.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(-8.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(6.5f, 0.2f, i);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(6.5f, 0.2f, -i);
            Instantiate(wuerfel, pos, rot);
        }
        for (i = -8.5f; i <= -2.5f; i++)
        {
            pos = new Vector3(i, 0.2f, 6);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(i, 0.2f, -6);
            Instantiate(wuerfel, pos, rot);
        }
        for (i = 0.5f; i <= 3.5f; i++)
        {
            pos = new Vector3(i, 0.2f, 6);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(i, 0.2f, -6);
            Instantiate(wuerfel, pos, rot);
        }
        for (i = 9.5f; i <= 11.5f; i++)
        {
            pos = new Vector3(i, 0.2f, 6);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(i, 0.2f, -6);
            Instantiate(wuerfel, pos, rot);
        }
        for (i = 7.5f; i <= 9.5f; i++)
        {
            pos = new Vector3(i, 0.2f, 9);
            Instantiate(wuerfel, pos, rot);
            pos = new Vector3(i, 0.2f, -9);
            Instantiate(wuerfel, pos, rot);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
