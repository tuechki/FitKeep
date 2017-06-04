using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Calendar() {

		Application.LoadLevel (4);
	}

	public void Statistics() {
		
		Application.LoadLevel (3);
	}

	public void Current_day() {
		
		Application.LoadLevel (2);
	}

	public void Options() {
		
		Application.LoadLevel (5);
	}

	public void Notes() {
		
		Application.LoadLevel (6);
	}


}
