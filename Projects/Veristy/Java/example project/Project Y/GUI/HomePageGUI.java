package GUI;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import Entity.*;
import EntityList.*;
import File.*;
import java.io.*;

public class HomePageGUI extends JFrame implements ActionListener{
	Font titleFont = new Font("Cambria",Font.BOLD,30);
	Font titleLabel = new Font("Cambria",Font.BOLD,15);
	JButton showAllFoodButton,showAllEmployeeButton,showAllDrinksButton,logOutButton;
	FoodMenu foodMenu;
	public HomePageGUI(){
		super("Home Page");
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize(850,700); //width, height
		this.setLocation(250,0); //x, y
		this.getContentPane().setBackground(new Color(229,204,255));
		this.setLayout(null);
		JLabel title = new JLabel("MALVOLENT KITCHEN");
		title.setBounds(300,20,500,50); //X,Y,W,H
		title.setFont(titleFont);

		int top = 100;
		int gap = 40;
		showAllFoodButton = new JButton("Manage FoodMenu ");
		showAllFoodButton.setBounds(350,150,200,50); //X,Y,W,H
		showAllFoodButton.setBackground(new Color(255,255,153));
		showAllFoodButton.setForeground(Color.BLACK);
		showAllFoodButton.setFont(titleLabel);
		showAllFoodButton.addActionListener(this);
		
		showAllEmployeeButton = new JButton("Manage Employee");
		showAllEmployeeButton.setBounds(350,300,200,50); //X,Y,W,H
		showAllEmployeeButton.setBackground(new Color(102,178,255));
		showAllEmployeeButton.setForeground(Color.BLACK);
		showAllEmployeeButton.setFont(titleLabel);
		showAllEmployeeButton.addActionListener(this);
		
		logOutButton = new JButton("LOGOUT");
		logOutButton.setBounds(400,600,100,20); //X,Y,W,H
		logOutButton.setBackground( Color.BLUE);
		logOutButton.setForeground(Color.WHITE);
		logOutButton.setFont(titleLabel);
		logOutButton.addActionListener(this);
		
		showAllDrinksButton = new JButton("Manage Drinks");
		showAllDrinksButton.setBounds(350,450,200,50); //X,Y,W,H
		showAllDrinksButton.setBackground(new Color(204,255,153));
		showAllDrinksButton.setForeground(Color.BLACK);
		showAllDrinksButton.setFont(titleLabel);
		showAllDrinksButton.addActionListener(this);
		
		super.add(showAllFoodButton);
		super.add(showAllEmployeeButton);
		super.add(showAllDrinksButton);
		this.add(title);
		this.add(logOutButton);
		this.setVisible(true);
	}
	@Override
public void actionPerformed(ActionEvent ae){
if (ae.getSource() == showAllFoodButton) {
        
        FoodMenu foodMenu = new FoodMenu(200);
	FFileIO.loadFoodsFromFile(foodMenu);
	FoodManagementGUI fmGUI= new FoodManagementGUI(foodMenu);
    }
	else if (ae.getSource() == showAllDrinksButton) {
     
        System.out.println("D.M CLICKED");
		DrinkMenu drinkMenu = new DrinkMenu(200);
	DFileIO.loadDrinksFromFile(drinkMenu);
	DrinkManagementGUI dmGUI= new DrinkManagementGUI(drinkMenu);
       
    }
	else if (ae.getSource() == showAllEmployeeButton) {
      
        System.out.println("E.M CLICKED");
				EmployeeList employeeList= new EmployeeList(20);
		FileIO.loadEmployeesFromFile(employeeList);
		EmployeeManagementGUI e= new EmployeeManagementGUI(employeeList);
     // EmployeeManagementGUI emGUI= new EmployeeManagementGUI();
    }
	else if (ae.getSource() == logOutButton) {
      
        System.out.println("Log Out Clicked");
		
		LoginPage loginPage = new LoginPage();
		
     // EmployeeManew Login();nagementGUI emGUI= new EmployeeManagementGUI();
    }
 
}

}