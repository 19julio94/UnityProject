using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour 
{

	// Use this for initialization
	public GameObject prefab;
	void Start ()
	{
		Instantiate (prefab, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
