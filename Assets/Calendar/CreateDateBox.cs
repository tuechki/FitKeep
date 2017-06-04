using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateDateBox : MonoBehaviour {
	Texture2D createTexture(int width, int height, Color color){
		Texture2D texture = new Texture2D(width, height);
		
		for (int y = 0; y < texture.height; y++)
		{
			for (int x = 0; x < texture.width; x++)
			{
				texture.SetPixel(x, y, color);
			}
		}
		texture.Apply();
		return texture;
	}

	Rect createBox (int xPosition, int yPosition, int width, int height){
		return new Rect (xPosition, yPosition, width, height);
	}

	MonthCalendar calendar;
	List<List<Box>> dates;

	// Use this for initialization
	void Start () {
		
		//Debug.Log("HAHHAHA");
		//Texture2D monthTexture = createTexture(256, 256, Color.red);
		calendar = new MonthCalendar (10, 50, 256, 256);
		dates = calendar.getDates();
	}

	void OnGUI(){
		int numberOfDate = 1;
		string render = "";
		for (int y = 0; y < dates.Count; y++) {
			for(int x = 0; x < dates[y].Count; x++){
				Color boxColor = Color.red;
				GUI.color = dates[y][x].getColor();
				//GUI.Box(

					if(GUI.Button(new Rect((float)dates[y][x].getXPosition(), 
					                      (float)dates[y][x].getYPosition(), 
					                      (float)dates[y][x].getWidth(),
				                       (float)dates[y][x].getHeight()), render)){
						//Debug.Log("Ajdeee");
						dates[y][x].setColor(Color.green);
					//screen.SetActive(true);
						
				}

					/*new Rect((float)dates[y][x].getXPosition(), 
				                 (float)dates[y][x].getYPosition(), 
				        		 (float)dates[y][x].getWidth(),
				                 (float)dates[y][x].getHeight()),*/ 
				        /*createTexture((int)dates[y][x].getWidth(), 
				              (int)dates[y][x].getHeight(),
				              boxColor)*/ 
							//render);

				if(numberOfDate >= calendar.getNumberOfDays() || numberOfDate < 3){
					render = "";
					numberOfDate++;
				}else{
					numberOfDate++;
					render = "" + numberOfDate.ToString();
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

		/*int numberOfDay = 1;
		for (int y = 0; y < dates.Count; y++) {
			for (int x = 0; x < dates[y].Count; x++, numberOfDay++) {

			}
			
		}*/	
			
	}

	void DrawBox (Rect position, Color color) {
		Color oldColor = GUI.color;
		
		GUI.color = color;
		GUI.color = oldColor;
		GUI.Box(position, "");
		

	}
}


