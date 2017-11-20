using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour {
	public gamemanage gm;
	public Rigidbody rb;
	public bool gamewin = false;
	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			rb.velocity = new Vector3 (0,0,0);
			gamewin = true;
			gm.wingame ();
		}
	}

}
