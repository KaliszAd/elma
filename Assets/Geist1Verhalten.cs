using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Geist1Verhalten : MonoBehaviour {

    public Transform goal;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        NavMeshAgent Geist1 = GetComponent<NavMeshAgent>();
        Geist1.destination = GameObject.Find("PacMan").transform.position;
    }
}
