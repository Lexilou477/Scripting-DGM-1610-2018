using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;
	public GameObject PC;
	public GameObject EnemyDeathParticle;
	public GameObject ProjectileParticle;
	public int PointsForKill;
	public int TimeOut;

	// Use this for initialization
	void Start () {
		PC = GameObject.Find("PC");

		EnemyDeathParticle = Resources.Load("Prefab/Generic") as GameObject;
		ProjectileParticle = Resources.Load("Prefab/Generic") as GameObject;

		if(PC.transform.localScale.x < 0)
			Speed = -Speed;

		Destroy(gameObject, TimeOut);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeathParticle, other.transform.position, other.transform.rotation);
			Destroy(other.gameObject);
			ScoreManager.AddPoints(PointsForKill);
		}

		
		Destroy(gameObject);
	}

	void OnCollisionEnter2D(Collision2D other){
		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
