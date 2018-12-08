using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeCounter : MonoBehaviour {

	public static int Life;
	Text LifeNumber;
	public Text LoseText;
	
	void Awake (){
		Time.timeScale = 1;
	}

	// Use this for initialization
	void Start () {
		LifeNumber = GetComponent<Text>();
		Life = 5;
		LoseText.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Life <= 0){
			Life = 0;
			LoseText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
			
		LifeNumber.text = " " + Life;

	}

	public static void AddLife (int AddLife){
		Life += AddLife;
	}
}
