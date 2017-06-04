using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Current_day_main : MonoBehaviour {
	
	static public int fragment_num; 
	public GameObject left, right;
	public GameObject pause_button, timer_button;
	public GameObject water, sleep;
	public GameObject fragment_01;

	void Start () {
	
		fragment_num = PlayerPrefs.GetInt("fragment_num_02", 1);
	}

	void Update () {
	
		if (fragment_num == 1) {

			left.SetActive (false);
			right.SetActive (true);
			timer_button.SetActive(false);
			pause_button.SetActive(false);
			water.SetActive(false);
			sleep.SetActive(false);
			fragment_01.SetActive (true);
		} else if (fragment_num == 2) {

			left.SetActive (true);
			right.SetActive (true);
			timer_button.SetActive(true);
			pause_button.SetActive(true);
			water.SetActive(false);
			sleep.SetActive(false);
			fragment_01.SetActive (false);
		} else {

			left.SetActive (true);
			right.SetActive (false);
			timer_button.SetActive(false);
			pause_button.SetActive(false);
			water.SetActive(true);
			sleep.SetActive(true);
			fragment_01.SetActive (false);
		}
	}

	public void Right_click() {

		fragment_num++;
		PlayerPrefs.SetInt ("fragment_num_02", fragment_num);
		PlayerPrefs.Save ();
	}
	
	public void Left_click() {
		
		fragment_num--;
		PlayerPrefs.SetInt ("fragment_num_02", fragment_num);
		PlayerPrefs.Save ();
	}
}
