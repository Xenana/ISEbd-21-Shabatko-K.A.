package tpL2;

import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

import tpL2.Form1;
import tpL2.ITransport;
import tpL2.LightPlane;
import tpL2.AirTransport;

public class Form1 {

	private JFrame frame;

	Color color;
	Color dopColor;
	int maxSpeed;
	int maxCountPass;
	int weight;
	boolean str;
	boolean en;

	private ITransport inter;
	private Frame Color;
	private Frame DopColor;
	private JTextField textMaxCountPass;
	private JTextField textMaxWeight;
	private JTextField textMaxSpeed;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Form1 window = new Form1();
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
	public Form1() {

		maxSpeed = 300;
		maxCountPass = 6;
		weight = 2000;

		initialize();
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 836, 519);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		final JPanel panel = new JPanel();
		panel.setBounds(10, 11, 803, 281);
		frame.getContentPane().add(panel);

		textMaxCountPass = new JTextField();
		textMaxCountPass.setBounds(218, 362, 48, 20);
		frame.getContentPane().add(textMaxCountPass);
		textMaxCountPass.setColumns(10);

		textMaxWeight = new JTextField();
		textMaxWeight.setBounds(218, 395, 48, 20);
		frame.getContentPane().add(textMaxWeight);
		textMaxWeight.setColumns(10);

		textMaxSpeed = new JTextField();
		textMaxSpeed.setBounds(218, 325, 48, 20);
		frame.getContentPane().add(textMaxSpeed);
		textMaxSpeed.setColumns(10);

		JLabel lblPass = new JLabel(
				"\u041A\u043E\u043B\u0438\u0447\u0435\u0441\u0442\u0432\u043E \u043F\u0430\u0441\u0441\u0430\u0436\u0438\u0440\u043E\u0432");
		lblPass.setBounds(10, 365, 177, 14);
		frame.getContentPane().add(lblPass);

		JLabel lblweight = new JLabel("\u0412\u0435\u0441 ");
		lblweight.setBounds(10, 398, 64, 14);
		frame.getContentPane().add(lblweight);

		JLabel lblSpeed = new JLabel(
				"\u0421\u043A\u043E\u0440\u043E\u0441\u0442\u044C");
		lblSpeed.setBounds(10, 328, 64, 14);
		frame.getContentPane().add(lblSpeed);

		JCheckBox chckbxStrips = new JCheckBox(
				"\u041F\u043E\u043B\u043E\u0441\u044B");
		chckbxStrips.setBounds(472, 338, 97, 23);
		frame.getContentPane().add(chckbxStrips);

		JCheckBox chckbxEngines = new JCheckBox(
				"\u0414\u0432\u0438\u0433\u0430\u0442\u0435\u043B\u0438");
		chckbxEngines.setBounds(472, 377, 97, 23);
		frame.getContentPane().add(chckbxEngines);

		JButton buttonSetPlane = new JButton(
				"\u0421\u0430\u043C\u043E\u043B\u0435\u0442");
		buttonSetPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (checkFields()) {
					inter = new Plane(maxSpeed, maxCountPass, weight,
							color);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawPlane(gr);

				}

			}
		});
		buttonSetPlane.setBounds(81, 296, 131, 23);
		frame.getContentPane().add(buttonSetPlane);

		JButton buttonSetLightPlane = new JButton(
				"\u041B\u0435\u0433\u043A\u0438\u0439 \u0441\u0430\u043C\u043E\u043B\u0435\u0442");
		buttonSetLightPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
					str = chckbxStrips.isSelected();
					en = chckbxEngines.isSelected();
					inter = new LightPlane(maxSpeed, maxCountPass, weight, color,
							str, en, dopColor);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawPlane(gr);
				}

			}
		});
		buttonSetLightPlane.setBounds(460, 296, 131, 23);
		frame.getContentPane().add(buttonSetLightPlane);

		final JButton buttonSetColor = new JButton(
				"\u041E\u0441\u043D\u043E\u0432\u043D\u043E\u0439  \u0446\u0432\u0435\u0442");
		buttonSetColor.setForeground(color);
		buttonSetColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color initialBackground = buttonSetColor.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					buttonSetColor.setForeground(foreground);
				}
				color = foreground;
			}
		});
		buttonSetColor.setBounds(95, 436, 131, 23);
		frame.getContentPane().add(buttonSetColor);

		final JButton buttonSetDopColor = new JButton(
				"\u0414\u043E\u043F\u043E\u043B\u043D\u0438\u0442\u0435\u043B\u044C\u043D\u044B\u0439 \u0446\u0432\u0435\u0442");
		buttonSetDopColor.setForeground(dopColor);
		buttonSetDopColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				Color initialBackground = buttonSetDopColor.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					buttonSetDopColor.setForeground(foreground);
				}
				dopColor = foreground;
			}
		});
		buttonSetDopColor.setBounds(449, 436, 172, 23);
		frame.getContentPane().add(buttonSetDopColor);

		JButton buttonMove = new JButton(
				"\u0414\u0432\u0438\u0436\u0435\u043D\u0438\u0435 ");
		buttonMove.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (inter != null) {
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.flyPlane(gr);
				}
			}
		});
		buttonMove.setBounds(676, 350, 128, 44);
		frame.getContentPane().add(buttonMove);

	}

	private boolean checkParse(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		return true;
	}

	private boolean checkFields() {
		if (checkParse(textMaxCountPass.getText()))
			maxCountPass = Integer.parseInt(textMaxCountPass.getText());
		if (checkParse(textMaxSpeed.getText()))
			maxSpeed = Integer.parseInt(textMaxSpeed.getText());

		if (checkParse(textMaxWeight.getText()))
			weight = Integer.parseInt(textMaxWeight.getText());

		return true;
	}
}
