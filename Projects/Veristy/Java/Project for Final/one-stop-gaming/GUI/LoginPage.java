package GUI;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import Entity.*;
import EntityList.*;
import File.*;

public class LoginPage extends JFrame implements ActionListener{
	JTextField nameTextField;
	JPasswordField passField;
	
	JButton loginButton, registerButton;
	
	Font font = new Font("Arial",Font.BOLD,20);
	
	public LoginPage(){
		super("Login page");
		this.setSize(850,700);
		this.setLocation(250,0);
		this.getContentPane().setBackground(new Color(221, 230, 237));
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLayout(null);
		
		JLabel nameLabel = new JLabel("User Name");
		nameLabel.setFont(font);
		nameLabel.setBounds(240,180,150,30);
	
		
		nameTextField = new JTextField();
		nameTextField.setFont(font);
		nameTextField.setBounds(350,180,200,30);
		
		
		JLabel passLabel = new JLabel( "Password" );
		passLabel.setFont(font);
		passLabel.setBounds(240,210,150,50);
		
		
		passField = new JPasswordField();
		passField.setFont(font);
		passField.setBounds(350,210,200,50);
		passField.setEchoChar('*');
		
		
		loginButton = new JButton("Login");
		loginButton.setFont(font);
		loginButton.setBounds(350,270,200,30);
		loginButton.addActionListener(this);
		
		registerButton = new JButton("Register");
		registerButton.setFont(font);
		registerButton.setBounds(350,310,200,30);
		registerButton.addActionListener(this);
		
		this.add(nameLabel);
		this.add(nameTextField);
		this.add(passLabel);
		this.add(passField);
		this.add(loginButton);
		this.add(registerButton);
		
		
		
		this.setVisible(true);
	}
	
	@Override
	public void actionPerformed(ActionEvent e){
			
			String userName = nameTextField.getText();
			String userPass = new String(passField.getPassword());
			
			if(loginButton == e.getSource()){
				if(UFileIO.checkUserFromFile(userName,userPass)){
					JOptionPane.showMessageDialog(this,"Successfully Logged In!");
					
					HomePageGUI hpGUI= new HomePageGUI();	
					
					this.setVisible(false);
				}else{
					JOptionPane.showMessageDialog(this,"Whoops! Something Went Wrong! Try Again.");
				}
			}
			if(registerButton == e.getSource()){
				 // System.out.println("Register Clicked");
				 Register reg=new Register();
			}
	}
}