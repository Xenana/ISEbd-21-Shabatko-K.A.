package tpL2;

import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

import tpL2.Form2;
import tpL2.ITransport;
import tpL2.LightPlane;
import tpL2.Panel;
import tpL2.AirTransport;
import tpL2.Aerodrome;

public class Form2 {
	
	private JFrame frame;

	Color color;
	Color dopColor;
	int maxSpeed;
	int maxCountPass;
	int weight;
	boolean str;
	boolean en;
	Aerodrome aerodrome;

	private JTextField Number;
	private String[] elements = new String[6];

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Form2 window = new Form2();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Form2() {

		maxSpeed = 300;
		maxCountPass = 6;
		weight = 2000;
		aerodrome = new Aerodrome(5);
		initialize();
		for(int i=0; i<6; i++){
			elements[i]="Уровень" + (i+1);
		}
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 670, 480);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		final JPanel panel = new Panel(aerodrome);
		panel.setBounds(0, 0, 364, 432);
		frame.getContentPane().add(panel);

		JButton SetPlane = new JButton(
				"\u0421\u0430\u043C\u043E\u043B\u0435\u0442");
		SetPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);
				if (colorDialog != null) {
					ITransport plane = new Plane(100, 4, 1000,
							colorDialog);
					int place = aerodrome.PutPlaneInParking(plane);
					panel.repaint();
					
					JOptionPane.showMessageDialog(null, "Ваше место: " + place);

				}

			}
		});
		SetPlane.setBounds(513, 170, 136, 23);
		frame.getContentPane().add(SetPlane);

		JButton SetLightPlane = new JButton("\u041B\u0435\u0433\u043A\u0438\u0439 \u0441\u0430\u043C\u043E\u043B\u0435\u0442");
		SetLightPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog1 = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);
				if (colorDialog1 != null) {
					Color colorDialog = JColorChooser.showDialog(null,
							"JColorChooser Sample", null);
					if (colorDialog != null) {
						ITransport plane = new LightPlane(300, 6, 2000,
								colorDialog1, true, true,colorDialog);
						int place = aerodrome.PutPlaneInParking(plane);
						panel.repaint();
						JOptionPane.showMessageDialog(null, "Ваше место: "
								+ place);
					}
				}

			}
		});
		SetLightPlane.setBounds(370, 169, 136, 23);
		frame.getContentPane().add(SetLightPlane);

		Number = new JTextField();
		Number.setBounds(476, 212, 86, 28);
		frame.getContentPane().add(Number);

		JLabel label = new JLabel("\u041C\u0435\u0441\u0442\u043E");
		label.setBounds(420, 220, 46, 14);
		frame.getContentPane().add(label);

		final JPanel panel_2 = new JPanel();
		
		panel_2.setBounds(404, 285, 204, 143);
		frame.getContentPane().add(panel_2);

		JButton Get = new JButton("\u0417\u0430\u0431\u0440\u0430\u0442\u044C");
		Get.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkPlace(Number.getText())) {
					ITransport plane = aerodrome.GetPlaneInParking(Integer
							.parseInt(Number.getText()));
					Graphics gr = panel_2.getGraphics();
					gr.clearRect(0, 0, panel_2.getWidth(), panel_2.getHeight());
					plane.setPosition(50, 80);
					plane.drawPlane(gr);
					panel.repaint();
				}
				

			}
		});
		Get.setBounds(462, 249, 89, 23);
		frame.getContentPane().add(Get);
	
	
	final JList list = new JList(elements);
		list.setBounds(464, 21, 99, 90);
		frame.getContentPane().add(list);
		
		JButton btnUp = new JButton(">>");
		btnUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				aerodrome.levelUp();
				 				list.setSelectedIndex(aerodrome.getCurrentLevel());
				 				panel.repaint();
			}
		});
		btnUp.setBounds(543, 117, 63, 23);
		frame.getContentPane().add(btnUp);
		
		JButton btnDown = new JButton("<<");
		btnDown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				aerodrome.levelDown();
				 				list.setSelectedIndex(aerodrome.getCurrentLevel());
				 				panel.repaint();
			}
		});
		btnDown.setBounds(423, 118, 73, 23);
		frame.getContentPane().add(btnDown);
		
		JLabel label_1 = new JLabel("Уровни");
		label_1.setBounds(492, 3, 46, 14);
		frame.getContentPane().add(label_1);
}

	private boolean checkPlace(String str) {
		try {
			Integer.parseInt(str);
		} catch (Exception e) {
			
			return false;
		}

		if (Integer.parseInt(str) > 20)
			return false;
		return true;
	}

}
