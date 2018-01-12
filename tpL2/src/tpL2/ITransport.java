package tpL2;

import java.awt.Graphics;

public interface ITransport {
	
	void flyPlane(Graphics g);

	void drawPlane(Graphics g);

	void setPosition(int x, int y);

	void loadPassenger(int count);

	int getPassenger();

}
