using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Notes : MonoBehaviour {

	public string textField;
	//public Text input, output;

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI() {

		textField = GUI.TextField (new Rect (500, 25, 100, 30), textField, 25);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Edit() {

		//input.text = output.text;
		//text += input.text;
		//input.text = text;
	}
}
