package tpL2;

import java.awt.Color;
import java.awt.Graphics;
import java.util.ArrayList;

import tpL2.ClassArray;
import tpL2.ITransport;

public class Aerodrome {

	ClassArray<ITransport> parking;
	 
 	int countPlaces = 20;
 	ArrayList<ClassArray<ITransport>> parkingStages;
 	int placeSizeWidth = 210;
 	int placeSizeHeight = 80;
 	int currentLevel;
 	 
 	public Aerodrome(int countStages)
 	{
 		parking = new ClassArray<ITransport>(countPlaces, null);
 		parkingStages = new ArrayList<ClassArray<ITransport>>(countStages);
 		for(int i=0;i<countStages;i++){
 			parkingStages.add(new ClassArray<ITransport>(countPlaces, null));
 		}
 	}
 	
 	public int getCurrentLevel(){
 		return currentLevel;
 	}
 	
 	public void levelUp(){
 		if (currentLevel + 1 < parkingStages.size()){
 			currentLevel++;
 		}
 	}
 	
 	public void levelDown(){
 		if(currentLevel>0){
 			currentLevel--;
 		}
 	}
 	 
 	 	public int PutPlaneInParking(ITransport plane)
 	 	{
 	 		return parkingStages.get(currentLevel).plus(parkingStages.get(currentLevel), plane);
 	 	}
 	 
 	 	public ITransport GetPlaneInParking(int ticket)
 	 	{
 	 		return parkingStages.get(currentLevel).minus(parkingStages.get(currentLevel), ticket);
 	 	}
 	 
 	 	public void Draw(Graphics g,int width,int height)
 	 	{
 	 		DrawMarking(g);
 	 		for(int i = 0; i < countPlaces; i++)
 	 		{
 	 			ITransport plane = parkingStages.get(currentLevel).getObject(i);
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
