using UnityEngine;
using System.Collections;

public class Box {

	private double xPosition;
	private double yPosition;
	private double width;
	private double height;
	private Texture2D texture;
	private Color color;
	
	public Box (double xPosition, double yPosition, double width, double height, Color color)
	{
		this.xPosition = xPosition;
		this.yPosition = yPosition;
		this.width = width;
		this.height = height;
		this.color = color;
		this.texture = getDefaultTexture(width, height, Color.red);

		Debug.Log("xPosition: " + xPosition + "  yPosition:" + yPosition + " texture:" + texture);
		
	}

	public Texture2D getDefaultTexture(double width, double height, Color color){

			Texture2D texture = new Texture2D((int)width, (int)height);
			
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


	public void setXPosition(int xPosition)
	{
		this.xPosition = xPosition;
	}
	
	public double getXPosition()
	{
		return this.xPosition;
	}
	
	public void setYPosition(int yPosition)
	{
		this.yPosition = yPosition;
	}
	
	public double getYPosition()
	{
		return this.yPosition;
	}
	
	public void setWidth(int width)
	{
		this.width = width;
	}
	
	public double getWidth()
	{
		return this.width;
	}
	
	public void setHeight(int height)
	{
		this.height = height;
	}
	
	public double getHeight()
	{
		return this.height;
	}
	
	public void setTexture(Texture2D texture)
	{
		this.texture = texture;
	}
	
	public Texture2D getTexture()
	{
		return this.texture;
	}

	public void setColor(Color color){
		this.color = color;
	}

	public Color getColor(){
		return this.color;
	}

}

