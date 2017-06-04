using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour {

	int coins;
	public Text text;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		coins = PlayerPrefs.GetInt ("coins", 0);
		text.text = "Coins: " + coins;
	}

	public void Exit() {

		Application.LoadLevel (1);
	}

	public void ClearData() {

	}
}
