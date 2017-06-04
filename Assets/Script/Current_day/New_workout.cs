using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class New_workout : MonoBehaviour {

	static public int reps;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Count_reps() {

		if (reps < 20) {

			reps++;
			gameObject.GetComponentInChildren<Text> ().text = "" + reps;
		}
	}
}
