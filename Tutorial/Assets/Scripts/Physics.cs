using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Physics : MonoBehaviour {

	public Rigidbody rb;


	// Use this for initialization
	void Start () 
	{

		float x = Random.Range (-1f, 1f);
		//velocidad instantanea usando la masa
		GetComponent<Rigidbody>().AddForce(new Vector3(x,0f,1f) * 100f,ForceMode.Impulse);

		//velocidad instantanea ignorando la masa
		//GetComponent<Rigidbody>().AddForce(Vector3.right * 50f,ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	/*void FixedUpdate () 
	{
		//****Fuerzas contuinuas
		//****Fuerza continua dependiendo de la masa

		//rb = GetComponent<Rigidbody>(); 
		//rb.AddForce (new Vector3(1f, 0f, 1f) * 50f, ForceMode.Force);
		//****Fuerza continua independiente de la masa

		//GetComponent<Rigidbody>().AddForce(Vector3.right * 50f,ForceMode.Acceleration);

		//****Fuerza que cancela la gravedad

		rb = GetComponent<Rigidbody>(); 
		rb.AddForce (Vector3.up * 50f, ForceMode.Force);
		
	}*/
}
