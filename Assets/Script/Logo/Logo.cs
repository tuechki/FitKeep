using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Logo : MonoBehaviour {
	
	public Image logo;
	public Text text;
	
	public int random_text;
	
	public int seconds = 2;
	
	public static string[] texts = new string[4];
	// Use this for initialization
	void Start () {
		
		GetText ();
		text.enabled = false;
		StartCoroutine(Change_Scene());
	}
	
	IEnumerator Change_Scene () {
		
		yield return new WaitForSeconds(seconds);
		logo.enabled = false;
		text.enabled = true;
		random_text = Random.Range (0,4);
		text.GetComponent<Text>().text = texts[random_text];
		yield return new WaitForSeconds(seconds);
		Application.LoadLevel(1);
	}
	
	
	void GetText () {
		
		texts[0] = "Sore Today, Strong Tomorrow";
		texts[1] = "Stop Making Excuses";
		texts[2] = "Fit is Not a Destination";
		texts[3] = "Work Out. Eat Well. Be Patient.";

	}
}
