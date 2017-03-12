using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalVerhalten : MonoBehaviour {

    string portal;
    private Vector3 endpunkt;

    // Use this for initialization
    void Start()
    {
        portal = gameObject.name;
        // Position vom Endpunkt initialisieren
        if (portal == "LinksPortal")
        {
            endpunkt = GameObject.Find("EndPunktvonLinksPortal").transform.position;
            //endpunkt.z = 2 * endpunkt.z;
        }
        else
        {
            endpunkt = GameObject.Find("EndPunktvonRechtsPortal").transform.position;
            //endpunkt.z = 2 * endpunkt.z;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        // Auf Konsole mitschreiben
        print(portal);
        print(endpunkt.ToString() );
        print(col.gameObject.name.ToString());

        // Nur PacMan durchlassen
        if (col.name.ToString() == "PacMan")
        {
            col.transform.position = endpunkt;
            //col.transform.Translate(endpunkt, Space.World);
        }

    }
}
