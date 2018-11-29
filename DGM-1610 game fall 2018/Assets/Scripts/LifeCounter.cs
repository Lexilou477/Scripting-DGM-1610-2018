using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour {

	public static int Life;
	Text LifeNumber;

	// Use this for initialization
	void Start () {
		LifeNumber = GetComponent<Text>();
		Life = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Life <= 0)
			Life = 0;
		LifeNumber.text = " " + Life;
	}

	public static void AddLife (int AddLife){
		Life += AddLife;
	}
}
