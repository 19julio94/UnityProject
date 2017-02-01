using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//velocidad instantanea usando la masa
		GetComponent<Rigidbody>().AddForce(Vector3.right * 50f,ForceMode.Impulse);

		//velocidad instantanea ignorando la masa
		//GetComponent<Rigidbody>().AddForce(Vector3.right * 50f,ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
