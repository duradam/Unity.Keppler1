using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVelocity : MonoBehaviour {

	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb.AddForce(new Vector3(.1f,5,.5f), ForceMode.Impulse);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
