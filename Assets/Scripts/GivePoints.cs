using UnityEngine;
using System.Collections;

public class GivePoints : MonoBehaviour {


	public bool isplayer1 = false;
	public bool isplayer2 = false;

	public int pointamount = 0;
	public GameObject manager;

	// Use this for initialization
	void Start () {
		
	}

	void sendpoints(){
		
		TheCook script = manager.GetComponent<TheCook> ();
		if (isplayer1)
			script.player2score += pointamount;
		if (isplayer2)
			script.player1score += pointamount;
		
		
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "sword") {

			sendpoints ();
		}

	}
}
