package GUI;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import Entity.*;
import EntityList.*;
import File.*;

public class Register extends JFrame implements ActionListener{
	JTextField nameTextField;
	JPasswordField passField;
	
	JButton BackButton, registerButton;
	
	Font font = new Font("Arial",Font.BOLD,20);
	
	public Register(){
		super("Registration page");
		this.setSize(850,700);
		this.setLocation(250,0);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLayout(null);
		
		JLabel nameLabel = new JLabel("Enter Name");
		nameLabel.setFont(font);
		nameLabel.setBounds(230,180,150,30);
	
		
		nameTextField = new JTextField();
		nameTextField.setFont(font);
		nameTextField.setBounds(350,180,200,30);
		
		
		JLabel passLabel = new JLabel( "Password" );
		passLabel.setFont(font);
		passLabel.setBounds(250,210,150,50);
		
		
		passField = new JPasswordField();
		passField.setFont(font);
		passField.setBounds(350,210,200,50);
		passField.setEchoChar('*');
		
		
		registerButton = new JButton("Register");
		registerButton.setFont(font);
		registerButton.setBounds(350,270,200,30);
		registerButton.addActionListener(this);
		
		BackButton = new JButton("Go Back");
		BackButton.setFont(font);
		BackButton.setBounds(350,310,200,30);
		BackButton.addActionListener(this);
		
		this.add(nameLabel);
		this.add(nameTextField);
		this.add(passLabel);
		this.add(passField);
		this.add(BackButton);
		this.add(registerButton);
		this.getContentPane().setBackground(new Color(204,229,225));
		
		this.setVisible(true);
	}
	
	@Override
	public void actionPerformed(ActionEvent e){
			
			String userName = nameTextField.getText();
			String userPass = new String(passField.getPassword());
			
			if(registerButton == e.getSource()){
				UFileIO.writeUserInFile(userName, userPass);
				JOptionPane.showMessageDialog(this,"Congratulations! Registration has been done successfully.");
				this.setVisible(false);
			} else if(BackButton == e.getSource()){
				LoginPage loginPage = new LoginPage();
			}
	}
}
