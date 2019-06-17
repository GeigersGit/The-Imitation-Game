using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class View : NetworkBehaviour {
	Transform player;
	Transform playerHead;
	float cutTimeout = 3;
	float cutTimeCount;
	Vector3 viewPoint = Vector3.zero;

	// Use this for initialization
	void Start () {
		//attach to random player
		if (isClient) { 
		/*	Transform t = GameObject.Find ("Player" + (Random.Range (1,3))).transform;
			Transform[] ch = t.GetComponentsInChildren<Transform> ();
			for(int i = 0;  i < ch.Length; i++ ) {
				Transform c = ch [i];
				if (c.name.Contains ("Head")) {
					playerHead = c;
					break;
				}
			};*/

		}
		cutTimeCount = cutTimeout;
	}

	// Update is called once per frame
	void Update () {
		if (isServer) {
			AutoCamera ();
		}
		if (isClient) {
			if (!playerHead) playerHead = GameObject.Find ("mixamorig:Head").transform;
			else transform.position = playerHead.position;
			// rotation is automatic in VR
		}	
	}

	[Server]
	private void AutoCamera() {
		cutTimeCount += Time.deltaTime;
		if (cutTimeCount > cutTimeout) {
			GameObject p = GameObject.Find ("mixamorig:Hips");
			player = p.transform;
			viewPoint = new Vector3(Random.Range (-6, 7),Random.Range (1, 5),Random.Range (-6, 7));
			cutTimeCount = 0;
			cutTimeout = 5; // Random.Range (5, 8);
		}
		if (player) {
			transform.position = Vector3.Slerp (transform.position, viewPoint+player.position, Time.deltaTime/cutTimeout);
			transform.LookAt (player.position + new Vector3 (0, 1f, 0));
		}
	}
}
