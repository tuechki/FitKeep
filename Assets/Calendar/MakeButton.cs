using UnityEngine;
using System.Collections;

public class MakeButton : MonoBehaviour 
{
	public Vector3[] someVector3Array;
	public int[] someIntArray;
	
	void Start()
	{
		someIntArray = new int[]
		{
			1, 2, 3, 4    
		};
		
		someVector3Array = new Vector3[]
		{
			new Vector3(0, 0, 0),
			new Vector3(50, 50, 0),
			new Vector3(100, 100, 0),
			new Vector3(150, 150, 0)
		};
	}
	
	void OnGUI() 
	{
		for (int i= 0; i < someIntArray.Length; i++)
		{
			if (GUILayout.Button(someIntArray[i].ToString()))
			{
				transform.position = someVector3Array[i];
			}
		}
		
		//GUILayout.Label("Position = "+transform.position);
	}
}