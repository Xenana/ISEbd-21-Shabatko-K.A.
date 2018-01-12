package tpL2;

import java.awt.Color;
import java.awt.Graphics;

import tpL2.ClassArray;
import tpL2.ITransport;

public class Aerodrome {

	ClassArray<ITransport> parking;
	 
 	int countPlaces = 20;
 	int placeSizeWidth = 210;
 	int placeSizeHeight = 80;
 	 
 	public Aerodrome()
 	{
 		parking = new ClassArray<ITransport>(countPlaces, null);
 	}
 	 
 	 	public int PutPlaneInParking(ITransport plane)
 	 	{
 	 		return parking.plus(parking, plane);
 	 	}
 	 
 	 	public ITransport GetPlaneInParking(int ticket)
 	 	{
 	 		return parking.minus(parking, ticket);
 	 	}
 	 
 	 	public void Draw(Graphics g,int width,int height)
 	 	{
 	 		DrawMarking(g);
 	 		for(int i = 0; i < countPlaces; i++)
 	 		{
 	 			ITransport plane = parking.getObject(i);
 	 			if (plane != null)
 	 			{
 	 				plane.setPosition(5 + i / 5 * placeSizeWidth + 8, i % 5 * placeSizeHeight + 35);
 	 				plane.drawPlane(g);
 	 			}
 	 		}
 	 		
 	 	}	 
 	 	public void DrawMarking(Graphics g)
 	 	{
 	 		g.setColor(Color.BLACK);
 	 		g.drawRect( 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
 	 		for(int i = 0; i < countPlaces / 5; i++)
 	 		{
 	 			for(int j = 0; j < 6; j++)
 	 			{
 	 				g.drawLine( i * placeSizeWidth,j* placeSizeHeight,i*placeSizeWidth+110,j*placeSizeHeight);
 	 			}
 	 			g.drawLine( i * placeSizeWidth, 0, i * placeSizeWidth,400);
 	 		}
 	 		
	 	}
}
