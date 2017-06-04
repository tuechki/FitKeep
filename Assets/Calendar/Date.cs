using UnityEngine;
using System.Collections;

public class Date : MonoBehaviour {

	private GameObject date;
	// Use this for initialization
	void Start () {
		Renderer rend = GetComponent<Renderer> ();
		rend.material.shader = Shader.Find ("Specular");
		rend.material.SetColor ("_SetColor", Color.red);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}	
