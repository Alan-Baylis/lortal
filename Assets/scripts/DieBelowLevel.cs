using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieBelowLevel : MonoBehaviour
{
	private GameObject player;
	public Transform destination;
	public float floorIsLava;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.y < floorIsLava) {
			this.player.transform.position = destination.position;
		}
	}
}
