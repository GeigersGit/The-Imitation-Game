using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class TheCook : NetworkBehaviour {

	public bool isserver = false;
	public bool isplayer1 = false;
	public bool isplayer2 = false;

	public Transform player1prefab;
	public Transform player2prefab;

	public int playerCount = 0;

	public GameObject player1;
	public GameObject player2;

	public int player1health = 100;

	public int player2health = 100;

	public int player1score;
	public int player2score;

	void Start () {
		
	}



	void OnPlayerConnected(NetworkPlayer player) {
		Debug.Log("Player " + playerCount++ + " connected from " + player.ipAddress + ":" + player.port);
		if (playerCount == 1)
			isplayer1 = true;
		if (playerCount == 2)
			isplayer2 = true;
	}


	void Update () {
		
		if (Network.isServer)
			isserver = true;
			

		if (player1health <= 0) {
			player1death ();
		}
		if (player2health <= 0) {
			player2death ();
		}
	}


	void player1death(){
		Destroy (player1);
		player2score++;
		Network.Destroy(player1.GetComponent<NetworkView>().viewID);
		//Instantiate(player1prefab, Vector3.zero);
		//Network.Instantiate(player1prefab, Vector3.zero);
	}
	void player2death(){
		Destroy (player2);
		player1score++;
		Network.Destroy(player2.GetComponent<NetworkView>().viewID);
		//Instantiate(player2prefab, Vector3.zero);
		//Network.Instantiate(player2prefab, Vector3.zero);
	}
}
