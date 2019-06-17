using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class UpdateTransform : NetworkBehaviour {
	[SyncVar]
	Vector3 position;
	[SyncVar]
	Quaternion rotation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isServer) {
			position = transform.localPosition;
			rotation = transform.localRotation;
		}
	
		if (isClient) {
			transform.localPosition = Vector3.Lerp(transform.localPosition,position,0.5f);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, rotation, 0.5f);
		}
	}
}
