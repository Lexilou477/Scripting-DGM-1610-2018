﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public int[] Eggs = new int[12];
	public string[] Jedi;
	public int[] Num = new int[5];
	public float[] Pie;
	public string[] Pets;

	// Use this for initialization
	void Start () {

		Eggs[0] = 1;
		Eggs[1] = 2;
		Eggs[2] = 3;
		Eggs[3] = 4;
		Eggs[4] = 5;
		Eggs[5] = 6;
		Eggs[6] = 7;
		Eggs[7] = 8;
		Eggs[8] = 9;
		Eggs[9] = 10;
		Eggs[10] = 11;
		Eggs[11] = 12;

		print(Eggs[8]);

		Jedi = new string[5];

		Jedi[0] = "Obi Wan Kenobi";
		Jedi[1] = "Yoda";
		Jedi[2] = "Mace Windu";
		Jedi[3] = "Kit Fisto";
		Jedi[4] = "Luke Skywalker";

		foreach(string item in Jedi){
			print("Jedi master " + item);
		}
		//make an array with a foreach loop, and one with a for loop that does the same thing
		//5 arrays with loops

		Num[0] = 1;
		Num[1] = 2;
		Num[2] = 3;
		Num[3] = 4;
		Num[4] = 5;

		// foreach(int item in Num){
		// 	print("Number " + item);
		// }
		for(int i=1; i <= 5; i++){
			print("Number " + i);
		}

		Pie = new float[4];

		Pie[0] = 4;
		Pie[1] = 3;
		Pie[2] = 2;
		Pie[3] = 1;

		foreach(float item in Pie){
			print(item + " pie is left!");
		}

		Pets = new string[6];

		Pets[0] = "Cat";
		Pets[1] = "Dog";
		Pets[2] = "Bird";
		Pets[3] = "Lizard";
		Pets[4] = "Fish";
		Pets[5] = "Bunny";

		foreach(string item in Pets){
			print("The pet shop has a " + item);
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
