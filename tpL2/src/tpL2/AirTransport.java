package tpL2;

import java.awt.Color;
import java.awt.Graphics;

public abstract class AirTransport implements ITransport {
	
	protected int startPosX;
	protected int startPosY;
	protected int countPassengers;
	public int MaxCountPassengers;
	public int MaxSpeed;
	public Color ColorBody;
	public int Weight;
	

	public abstract void flyPlane(Graphics g);

	public abstract void drawPlane(Graphics g);

	public int getMaxSpeed() {
		return MaxSpeed;
	}

	protected void setMaxSpeed(int MaxSpeed) {
		this.MaxSpeed = MaxSpeed;
	}

	public int getMaxCountPassengers() {
		return MaxCountPassengers;

	}

	protected void setMaxCountPassengers(int MaxCountPassengers) {
		this.MaxCountPassengers = MaxCountPassengers;
	}

	public int getWeight() {
		return Weight;
	}

	protected void setWeight(int Weight) {
		this.Weight = Weight;
	}

	public void setPosition(int x, int y) {
		startPosX = x;
		startPosY = y;
	}

}
