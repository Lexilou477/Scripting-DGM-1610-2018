﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	// Shoot variables
	public Transform FirePoint;
	public GameObject Projectile;
	static bool enabled = true;
	// Use this for initialization
	void Start () {
		Projectile = Resources.Load("Prefab/Projectile") as GameObject;
		//Projectile = GameObject.Find("Projectile");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl)){
			if (enabled) {
			Instantiate(Projectile,FirePoint.position, FirePoint.rotation);
			AmmoCounter.LoseAmmo();
			}
		}
		
		
	}

	public static void enableShoot() {
		enabled = true;
	}

	public static void disableShoot() {
		enabled = false;
	}

}
