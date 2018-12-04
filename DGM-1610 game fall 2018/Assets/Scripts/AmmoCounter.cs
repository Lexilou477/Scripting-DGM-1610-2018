﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour {

	public static int Ammo;
	public int MaxAmmo;
	Text AmmoNumber;

	// Use this for initialization
	void Start () {
		AmmoNumber = GetComponent<Text>();
		Ammo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Ammo <= 0){
			Ammo = 0;
		}
		else if (Ammo >= MaxAmmo){
			Ammo = MaxAmmo;
		}
		else {
			AmmoNumber.text = " " + Ammo;
		}
			
	}
	public static void AddAmmo (int AddAmmo){
		Ammo += AddAmmo;
	}
}
