 package tpL2;

import java.awt.Color;
import java.awt.Graphics;

public class LightPlane extends Plane {
	
	private boolean Strips;
	private boolean Engines;
	private Color dopColor;

	public LightPlane(int maxSpeed, int maxCountPassengers, int weight, Color color,
			boolean Strips, boolean Engines, Color dopColor) {
		super(maxCountPassengers, maxSpeed, weight, color);
		this.Strips = Strips;
		this.Engines = Engines;
		this.dopColor = dopColor;
	}

	protected void drawPlanee(Graphics g) {
		super.drawPlanee(g);

		if (Strips) {
			g.setColor(Color.BLACK);
            g.drawOval(startPosX, startPosY, 100, 20);
            g.drawLine(startPosX + 25, startPosY, startPosX + 50, startPosY - 25);
            g.drawLine(startPosX + 50, startPosY - 25, startPosX + 50, startPosY);
            g.drawLine(startPosX + 25, startPosY + 10, startPosX + 40, startPosY + 25);
            g.drawLine(startPosX + 40, startPosY + 25, startPosX + 50, startPosY + 10);
            g.drawLine(startPosX + 75, startPosY, startPosX + 90, startPosY - 25);
            g.drawLine(startPosX + 90, startPosY - 25, startPosX + 110, startPosY - 25);
            g.drawLine(startPosX + 110, startPosY - 25, startPosX + 90, startPosY);
            g.drawRect(startPosX + 30, startPosY - 10, 20, 10);
            g.drawRect(startPosX + 30, startPosY + 20, 20, 10);

            g.setColor(ColorBody);
            g.fillOval(startPosX, startPosY, 100, 20);
            
            g.setColor(dopColor);
            g.fillOval(startPosX + 30, startPosY - 10, 20, 10);
            g.fillOval(startPosX + 30, startPosY + 20, 20, 10);

		}

		if (Engines) {
			g.setColor(Color.BLACK);
            g.drawRect(startPosX + 85, startPosY - 15, 20, 10);
            
            g.setColor(dopColor); 
            g.fillRect(startPosX + 85, startPosY - 15, 20, 10);

		}
		
	}

}
