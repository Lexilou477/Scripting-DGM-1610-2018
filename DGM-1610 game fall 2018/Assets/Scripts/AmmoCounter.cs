using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCounter : MonoBehaviour {

	public int Ammo;
	public int MaxAmmo;
	Text AmmoNumber;

	// Use this for initialization
	void Start () {
		AmmoNumber = GetComponent<Text>();

		Ammo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Ammo < 0)
		Ammo = 0;
		
		AmmoNumber.text = " " + Ammo;
		
	}

	public static void AddAmmo (int AmmoToAdd){
		Ammo += AmmoToAdd;
	}
}
