using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {

	int is_started;
	public Text timer, button_text, pause_text;
	float time;
	int hours, minutes;
	DateTime lastMinimize, now;


	void Start () {
	
		is_started = PlayerPrefs.GetInt("is_started", 0);
		time = PlayerPrefs.GetInt("time", 0);
		minutes = PlayerPrefs.GetInt("minutes", 0);
		hours = PlayerPrefs.GetInt("hours", 0);
	}
	

	void Update () {

		if (is_started == 0 && Current_day_main.fragment_num == 2) 
			button_text.GetComponentInChildren<Text> ().text = "Start";
		if (is_started == 1 && Current_day_main.fragment_num == 2)
			button_text.GetComponentInChildren<Text> ().text = "Stop";

		if (is_started == 1) {

			time += Time.deltaTime;

			if (time >= 60) {

				minutes++;
				time = 0;
			}

			if (minutes >= 60) {

				hours++;
				minutes = 0;
			}

			timer.text = hours +"h: "+ minutes +"m: "+(int)time + "s";
		}

		PlayerPrefs.SetInt("time", (int)time);
		PlayerPrefs.SetInt("minutes", minutes);
		PlayerPrefs.SetInt("hours", hours);
		PlayerPrefs.Save();
	}

	void OnApplicationPause(bool pauseStatus)
	{
		if (pauseStatus && is_started == 1) {

			lastMinimize = DateTime.Now;
		}

		if (!pauseStatus && is_started == 1) {

			now = DateTime.Now;
			TimeSpan span = now - lastMinimize;
			time += ((float)span.TotalSeconds) % 60;
			minutes += ((int)span.TotalSeconds) / 60;
			hours += ((int)span.TotalSeconds) / 3660;
		}
	}

	public void OnClick() {

		if (is_started == 0) {

			button_text.GetComponentInChildren<Text> ().text = "Stop"; 
			is_started = 1;
			PlayerPrefs.SetInt("is_started", is_started);
			PlayerPrefs.Save();
		} else {

			button_text.text = "Start"; 
			is_started = 0;
			time = 0;
			minutes = 0;
			hours = 0;
			PlayerPrefs.SetInt("is_started", is_started);
			PlayerPrefs.SetInt("time", (int)time);
			PlayerPrefs.SetInt("minutes", minutes);
			PlayerPrefs.SetInt("hours", hours);
			PlayerPrefs.Save();

			timer.text = hours +"h: "+ minutes +"m: "+(int)time + "s";
		}
	}

	public void Pause() {

		if (is_started == 1) {

			pause_text.text = "Resume"; 
			is_started = 0;
		} else {

			pause_text.text = "Pause"; 
			is_started = 1;
		}
	}
}
