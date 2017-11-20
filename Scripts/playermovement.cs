using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {
	public Rigidbody rb;
	public float forwardforce;
	public float sidespeed;
	private bool left;
	private bool right;
	private float maxvel = 50.0f;
	void Start () {
		left = false;
		right = false;

	}
	void Update(){
		if(Input.GetKey("d")){
			right = true;
		}
		if(Input.GetKey("a")){
			left = true;
		}
		if (rb.velocity.z >= maxvel) {
			rb.velocity = new Vector3 (rb.velocity.x,rb.velocity.y,maxvel);
		}

	}
	void FixedUpdate () {
		rb.AddForce (0, 0, forwardforce*Time.deltaTime);
		if(right){
			rb.AddForce(sidespeed*Time.deltaTime,0,0,ForceMode.VelocityChange);
			right = false;
		}
		if(left){
			rb.AddForce(-sidespeed*Time.deltaTime,0,0,ForceMode.VelocityChange);
			left = false;
		}
	}
}
