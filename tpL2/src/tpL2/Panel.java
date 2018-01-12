package tpL2;

import java.awt.Graphics;

import javax.swing.JPanel;

import tpL2.Aerodrome;

public class Panel extends JPanel {
	
	 Aerodrome parking;

	public Panel(Aerodrome aero) {
		this.parking = aero;
	}

	public void paint(Graphics g) {
		g.clearRect(0, 0, this.getWidth(), this.getHeight());
		parking.Draw(g, this.getWidth(), this.getHeight());
	}

}
