using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour {
    int screenshot_count = 0;
	
	// Update is called once per frame
	void Update () {
        screenshot_count = PlayerPrefs.GetInt("screenshot", 1);
    }
    public void TakeScreenShot()
    {
        string name = "Screenshot" + screenshot_count;
        Application.CaptureScreenshot(name);
        screenshot_count++;
        PlayerPrefs.SetInt("screenshot", screenshot_count);
        PlayerPrefs.Save();
    }
}
