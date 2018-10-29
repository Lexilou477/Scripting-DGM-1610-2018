using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopQuiz : MonoBehaviour {

	public int NumberOne;
	public int NumberTwo;
	private int Total;

	//function call
	public void Add (){
		Calculator (NumberOne, NumberTwo);
	}
	
	void Calculator (int NumberOne, int NumberTwo) {
		Total = NumberOne + NumberTwo;
		print (Total);
	}

	// Use this for initialization
	void Start () {
		Add ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
