using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int Num;
	public string Name;
	public string Fruit;
	public float Loto;
	public bool Light;

	// Use this for initialization
	
	void Start () {
		// if(Num == 1){
		// 	print("Hurray, you picked one!");
		// }
		// else if(Num == 2){
		// 	print("Hurray, you picked two!");
		// }
		// else{
		// 	print("Boo, you didn't pick one!");
		// }
	// Num picks the case number, so if you make Num 1, you will print case 1
	// Case designates Variable(Num)^	
	//default is a catch all, whatever doesn't have a case
		// switch(Num){
		// 	case 4:
		// 		print("You picked " + Num);
		// 	break;

		// 	case 3:
		// 		print("You picked " + Num);
		// 	break;

		// 	case 6:
		// 		print("You picked " + Num);
		// 	break;

		// 	case 10:
		// 		print("You picked " + Num);
		// 	break;

		// 	default:
		// 		print("I don't understand " + Num);
		// 	break;
		// }

		switch(Name){
			case "Jason":
				print("Welcome to camp Crystal Lake " + Name);
			break;

			case "Michael":
				print("Welcome to Haddonfield, Illonois " + Name);
			break;

			case "Freddie":
				print("Welcome to Elm Street " + Name);
			break;

			case "LeatherFace":
				print("The stars and stripes are big at night...Deep in the heart of Texas");
			break;

			default:
				print("I don't know " + Name);
			break;

		}
		
		// switch(Fruit){
		// 	case "Apple":
		// 		print("Good choice, you picked " + Fruit);
		// 	break;
		// 	case "Orange":
		// 		print("Good choice, you picked " + Fruit);
		// 	break;
		// 	case "Banana":
		// 		print("Good choice, you picked " + Fruit);
		// 	break;
		// 	default:
		// 		print("We don't have anymore " + Fruit);
		// 	break;
		// }

		// switch(Loto){
		// 	case 4.5:
		// 		print("You Win! The lucky number was " + Loto);
		// 	break;
		// 	case 7:
		// 		print("You Win! The lucky number was " + Loto);
		// 	break;
		// 	case 1000:
		// 		print("You Win! The lucky number was " + Loto);
		// 	break;
		// 	default:
		// 		print("Sorry, try again :(");
		// 	break;
		// }

		switch(Light){
			case true:
				print("The light is on!");
			break;
			case false:
				print("The light is off!");
			break;
		}
	}
	
	
}
