using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public Transform player;
	public Text scoretext;
	public playercollision ply;
	private int plyscore=0;
	public endtrigger winwin;
	// Update is called once per frame
	void Update () {
		plyscore++;
		if (!ply.plydead && !winwin.gamewin) {
			scoretext.text = plyscore.ToString ();
		} else {
			plyscore = 0;
		}
		}
}
