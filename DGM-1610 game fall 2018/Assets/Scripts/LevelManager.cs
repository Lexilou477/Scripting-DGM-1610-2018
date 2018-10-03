using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player;

	//Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnDelay;

	//Point Penalty on Death
	public int PointPenalty;

	//Store Gravity Value (for float on respawn/resets gravity)
	private float GravityStore;

	// Use this for initialization
	void Start () {
		Player = FindObjectOfType<Rigidbody2D> ();
	}

	//Spawn Delay
	public void RespawnPlayer () {
		StartCoroutine ("RespawnPlayerCo");
	}
	
	//Coroutine function
	public IEnumerator RespawnPlayerCo () {
		//Generate Death Particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//Hide Player
		//player.enabled = false;
		Player.GetComponent<Renderer> ().enabled = false;
		//Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D> ().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Point Penalty
		ScoreManager.AddPoints(-PointPenalty);
		//Debug Message
		Debug.Log ("Player Respawn");
		//Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
	}
}
