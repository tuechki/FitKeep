using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour {

	public Image back;
	public Sprite back_1, back_2, back_3, back_4, back_5; 

	int count;

	// Use this for initialization
	void Start () {

		count = Random.Range (0, 5);

		back = GetComponent<Image>();

		if (count == 0)
			back.sprite = back_1;
		if (count == 1)
			back.sprite = back_2;
		if (count == 2)
			back.sprite = back_4;
		if (count == 3)
			back.sprite = back_3;
		if (count == 4)
			back.sprite = back_5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
