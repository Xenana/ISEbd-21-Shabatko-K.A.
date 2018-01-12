package tpL2;

import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;

public class Plane extends AirTransport {
	
	protected int countPassengers;
	public int MaxCountPassengers;

	protected void setMaxSpeed(int value) {
		if (value > 0 && value < 400) {
			super.setMaxSpeed(value);
		} else {
			super.setMaxSpeed(300);
		}
	}

	protected void setMaxCountPassengers(int value) {
		if (value > 0 && value < 7) {
			super.setMaxCountPassengers(value);
		} else {
			super.setMaxCountPassengers(6);
		}
	}

	protected void setWeight(int value) {
		if (value > 1500 && value < 2150) {
			super.setWeight(value);
		} else {
			super.setWeight(2000);
		}
	}

	public Plane(int maxSpeed, int maxCountPassengers, int weight, Color color) {
		this.MaxSpeed = maxSpeed;
		this.MaxCountPassengers = maxCountPassengers;
		this.ColorBody = color;
		this.Weight = weight;
		this.countPassengers = 0;
		Random rand = new Random();
		startPosX = rand.nextInt(500);
		startPosY = rand.nextInt(300);
	}

	public void flyPlane(Graphics g) {

		startPosX -= (MaxSpeed / (float) Weight / (countPassengers == 0 ? 1
				: countPassengers));
		drawPlane(g);
	}

	public void drawPlane(Graphics g) {
		drawPlanee(g);
	}

	protected void drawPlanee(Graphics g) {
		g.setColor(Color.BLACK);
        g.drawOval(startPosX, startPosY, 100, 20);
        g.drawLine(startPosX + 25, startPosY, startPosX + 50, startPosY - 25);
        g.drawLine(startPosX + 50, startPosY - 25, startPosX + 50, startPosY);
        g.drawLine(startPosX + 25, startPosY + 10, startPosX + 40, startPosY + 25);
        g.drawLine(startPosX + 40, startPosY + 25, startPosX + 50, startPosY + 10);
        g.drawLine(startPosX + 75, startPosY, startPosX + 90, startPosY - 25);
        g.drawLine(startPosX + 90, startPosY - 25, startPosX + 110, startPosY - 25);
        g.drawLine(startPosX + 110, startPosY - 25, startPosX + 90, startPosY);


        g.setColor(ColorBody);
        g.fillOval(startPosX, startPosY, 100, 20);

	}

	@Override
	public void loadPassenger(int count) {
	}

	@Override
	public int getPassenger() {
		return 0;
	}
	

}
