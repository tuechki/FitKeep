using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExampleClass : MonoBehaviour {
	public Texture tex;
	void OnGUI() {
		if (!tex)
			Debug.LogError("No texture found, please assign a texture on the inspector");
		
		if (GUILayout.Button(tex))
			Debug.Log("Clicked the image");
		
		if (GUILayout.Button("I am a regular Automatic Layout Button"))
			Debug.Log("Clicked Button");
		
	}
}