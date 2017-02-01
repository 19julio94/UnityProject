using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public float deltaRotation =30f;
	public float deltaMovement=10f;
	public Color color;

	//public float r,g,b; Variable float para elegir el color que nosotros queramos


	// Use this for initialization
	void Start () 
	{
		//Con este metodo lo que conseguimos es que nos salga un selector de color ya asi colorear nuestro cubo con el color seleccionado
		GetComponent<Renderer> ().material.color = color;
		//GetComponent<Renderer> ().material.color = new Color (r, g, b);
		//Con este metodo podremos elegir el color de nuestro cubo ,no es muy exacto ya que hasat que le demos a play no sabremos que color hemos elegido
	}
	
	// Update is called once per frame
	void Update ()
	{
		Rotate();
		Movement ();
	}

	void Rotate()
	{
		if(Input.GetKey(KeyCode.Q))
		transform.Rotate (new Vector3 (0f, -deltaRotation, 0f) * Time.deltaTime); 

		else if(Input.GetKey(KeyCode.E))
			transform.Rotate (new Vector3 (0f, deltaRotation, 0f) * Time.deltaTime); 

	}

	void Movement()
	{
		if (Input.GetKey (KeyCode.W))
			transform.Translate (Vector3.forward * deltaMovement * Time.deltaTime);
		else if (Input.GetKey (KeyCode.S))
			transform.Translate (Vector3.back * deltaMovement * Time.deltaTime);
		else if (Input.GetKey (KeyCode.A))
			transform.Translate (Vector3.left * deltaMovement * Time.deltaTime);
		else if (Input.GetKey (KeyCode.D))
			transform.Translate (Vector3.right * deltaMovement * Time.deltaTime);
		

	}

}
