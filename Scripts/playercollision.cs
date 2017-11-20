using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour {
	public playermovement ply;
	public Rigidbody rb;
	public bool plydead = false;
	void OnCollisionEnter(Collision col){ // when player collides
		if(col.collider.tag=="obstacle"){
			ply.enabled = false;
			plydead = true;
			rb.velocity = new Vector3(0,0,0);
			FindObjectOfType<gamemanage> ().endgame ();
			plydead = false;
		}
	}

}
