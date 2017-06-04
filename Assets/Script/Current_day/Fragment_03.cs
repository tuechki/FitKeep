using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fragment_03 : MonoBehaviour {

	float water_value;
	int sleep_value;
	public Text water, sleep;

	void Start () {
	
		water_value = PlayerPrefs.GetInt("water", 0);
		sleep_value = PlayerPrefs.GetInt("sleep", 0);

		if (water_value >= 1000) 
			water.text = water_value / 1000 + "l";
		else 
			water.text = water_value + "ml";

		sleep.text = sleep_value + "h";
	}

	void Update () {
	
	}

	public void Water() {

		water_value += 100;
		PlayerPrefs.SetInt ("water", (int)water_value);
		PlayerPrefs.Save ();

		if (water_value >= 1000) 
			water.text = water_value / 1000 + "l";
		else 
			water.text = water_value + "ml";
	}

	public void Sleep() {

		if (sleep_value < 12) 
			sleep_value++;

		PlayerPrefs.SetInt ("sleep", sleep_value);
		PlayerPrefs.Save ();

		sleep.text = sleep_value + "h";
	}
}
