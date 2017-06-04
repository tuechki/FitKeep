using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour {

	int scr_count;

	void Update() {

		scr_count = PlayerPrefs.GetInt ("screenshot", 1);
	}

    public void TakeScreenShot()
    {
		string name = "Screenshot" + scr_count.ToString ();
		scr_count++;
		PlayerPrefs.SetInt ("screenshot", scr_count);
		PlayerPrefs.Save ();
		Application.CaptureScreenshot("" + name + ".png");
    }
}
