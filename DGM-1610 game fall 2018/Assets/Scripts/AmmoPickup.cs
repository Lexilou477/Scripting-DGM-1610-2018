using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {

	public int AddAmmo;
	
	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D>() == null)
			return;
		AmmoCounter.AddAmmo(AddAmmo);
		
		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
