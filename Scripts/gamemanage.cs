using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanage : MonoBehaviour {
	bool once = false;
	float delay = .5f;
	public GameObject ui;
	public Rigidbody rb;
	public playermovement ply;
	public void wingame(){
		ui.SetActive (true);
	}
	public void endgame(){
		if (!once) {
			once = true;
			Invoke ("restart", delay);
			once = false;
		
		}
	}
	void restart(){
		rb.position = new Vector3 (0f, 1f, 0f);
		ply.enabled = true;
	}

}
