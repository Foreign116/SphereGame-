using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour {
	public Transform player;
	public Vector3 offset;
	public playercollision dead;
	// Update is called once per frame
	void Update () {
		
			transform.position = player.position + offset; // setting camera postion and adding offset
		
	}
}