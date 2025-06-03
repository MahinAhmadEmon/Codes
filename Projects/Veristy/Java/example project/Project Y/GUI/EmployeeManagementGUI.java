package GUI;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import Entity.*;
import EntityList.*;
import java.io.*;
import File.FileIO;

public class EmployeeManagementGUI extends JFrame implements ActionListener{
	Font titleFont = new Font("Algerian",Font.BOLD,30);
	Font titleLabel = new Font("Cambria",Font.BOLD,15);
	JTextField  idTextField,nameTextField,ageTextField,shiftTextField,salaryTextField,searchTextField,deleteTextField;
	JButton addButton,updateButton,searchButton,deleteButton,clearButton,showAllButton,backButton,saveButton;
	JTextArea textArea;
	
	
	EmployeeList employeeList;
	public EmployeeManagementGUI(EmployeeList employeeList){
		super("Malvolent Kitchen");
		
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize(850,700); //width, height
		this.setLocation(250,0); //x, y
		this.getContentPane().setBackground(new Color(102,178,255));
		this.setLayout(null);
		this.employeeList=employeeList;
		//============= Title ===========
		JLabel title = new JLabel("Malvolent Kitchen!");
		title.setBounds(300,10,500,50); //X,Y,W,H
		title.setFont(titleFont);
		//============Sub Title===========
		JLabel subTitle = new JLabel("Employeelist");
		subTitle.setBounds(400,60,320,50); //X,Y,W,H
		subTitle.setFont(new Font("Cambria",Font.BOLD,25));

		//============ Entry Form ===========
		int top = 100;
		int gap = 40;
		//============ ID Entry  ===========
		JLabel idLabel = new JLabel("ID:");
		idLabel.setBounds(20,top,200,30); //X,Y,W,H
		idLabel.setFont(titleLabel);
		idTextField = new JTextField();
		idTextField.setBounds(20,top+=gap,200,30); //X,Y,W,H
		idTextField.setFont(titleLabel);
		//============ Name Entry  ===========
		JLabel nameLabel = new JLabel("Name:");
		nameLabel.setBounds(20,top+=gap,200,30); //X,Y,W,H
		nameLabel.setFont(titleLabel);
		nameTextField = new JTextField();
		nameTextField.setBounds(20,top+=gap,200,30); //X,Y,W,H
		nameTextField.setFont(titleLabel);
		//=====================
		JLabel ageLabel = new JLabel("Age:");
		ageLabel.setBounds(20,top+=gap,200,30); //X,Y,W,H
		ageLabel.setFont(titleLabel);
		ageTextField = new JTextField();
		ageTextField.setBounds(20,top+=gap,200,30); //X,Y,W,H
		ageTextField.setFont(titleLabel);
		//=======================
		top = 100;
		gap = 40;
		//===========Search Entry  ===========
		JLabel searchLabel = new JLabel("Search By Employee ID");
		searchLabel.setBounds(600,top,200,30); //X,Y,W,H
		searchLabel.setFont(titleLabel);
		searchTextField = new JTextField();
		searchTextField.setBounds(600,top+=gap,200,30); //X,Y,W,H
		searchTextField.setFont(titleLabel);
		searchButton = new JButton("SEARCH");
		searchButton.setBounds(600,top+=gap,200,30); //X,Y,W,H
		searchButton.setBackground(Color.YELLOW);
		searchButton.setFont(titleLabel);
		searchButton.addActionListener(this);

		//============ Delete Entry  ===========
		JLabel deleteLabel = new JLabel("Delete By  ID");
		deleteLabel.setBounds(600,top+=gap,200,30); //X,Y,W,H
		deleteLabel.setFont(titleLabel);
		deleteTextField = new JTextField();
		deleteTextField.setBounds(600,top+=gap,200,30); //X,Y,W,H
		deleteTextField.setFont(titleLabel);
		deleteButton = new JButton("DELETE");
		deleteButton.setBounds(600,top+=gap,200,30); //X,Y,W,H
		deleteButton.setBackground(Color.RED);
		deleteButton.setForeground(Color.WHITE);
		deleteButton.setFont(titleLabel);
		deleteButton.addActionListener(this);
		
		
		backButton = new JButton("<= Back");
		backButton.setBounds(600,500,200,30);		
		backButton.setBackground(new Color(190, 49, 68));
		backButton.setForeground(Color.WHITE);
		backButton.addActionListener(this);
		
		saveButton = new JButton("SAVE");
		saveButton.setBounds(600,550,200,30);		
		saveButton.setBackground(new Color(91, 154, 139));
		saveButton.setForeground(Color.WHITE);
		saveButton.addActionListener(this);
		
		
		///////////////// Show All  information ///////////////
		showAllButton = new JButton("SHOW ALL Employee");
		showAllButton.setBounds(600,355,200,30); //X,Y,W,H
		showAllButton.setBackground(Color.PINK);
		showAllButton.setForeground(Color.BLACK);
		showAllButton.setFont(titleLabel);
		showAllButton.addActionListener(this);
		///////////////// Clear Screen ///////////////
		clearButton = new JButton("CLEAR SCREEN");
		clearButton.setBounds(600,400,200,30); //X,Y,W,H
		clearButton.setBackground(Color.DARK_GRAY);
		clearButton.setForeground(Color.WHITE);
		clearButton.setFont(titleLabel);
		clearButton.addActionListener(this);
				

        JLabel shiftLabel = new JLabel("Shift:");
		shiftLabel.setBounds(20,top+=gap,200,30); //X,Y,W,H
		shiftLabel.setFont(titleLabel);
	    shiftTextField = new JTextField();
		shiftTextField.setBounds(20,top+=gap,200,30); //X,Y,W,H
		shiftTextField.setFont(titleLabel);
		
		JLabel salaryLabel = new JLabel("Salary:");
	    salaryLabel.setBounds(20,top+=gap,200,30); //X,Y,W,H
		salaryLabel.setFont(titleLabel);
		salaryTextField = new JTextField();
	    salaryTextField.setBounds(20,top+=gap,200,30); //X,Y,W,H
		salaryTextField.setFont(titleLabel);

		salaryTextField = new JTextField();
		salaryTextField.setBounds(20,top,200,30); //X,Y,W,H
		salaryTextField.setFont(titleLabel);
		//============Buttons===========
		addButton = new JButton("ADD");
		addButton.setBounds(20,top+=gap+20,200,30); //X,Y,W,H
		addButton.setBackground(Color.GREEN);
		addButton.setFont(titleLabel);
		addButton.addActionListener(this);
		updateButton = new JButton("UPDATE");
		updateButton.setBounds(20,top+=gap,200,30); //X,Y,W,H
		updateButton.setBackground(Color.BLUE);
		updateButton.setForeground(Color.WHITE);
		updateButton.setFont(titleLabel);
		updateButton.addActionListener(this);

		//=========== DISPLAY  AREA ===========
		textArea = new JTextArea();
		//textArea.setBounds(0,0,300,500);
		textArea.setFont(titleLabel );
		reloadAllEmployees();
		textArea.setEditable(false);
		JScrollPane jsp = new JScrollPane(textArea);
		jsp.setBounds(280,120,300,500);
		
		
		this.add(jsp);

		this.add(title);
		this.add(subTitle);
		this.add(idLabel);
		this.add(idTextField);
		this.add(nameLabel);
		this.add(nameTextField);
		this.add(ageLabel);
		this.add(ageTextField);
		this.add(shiftLabel);
		this.add(shiftTextField);
		this.add(salaryLabel);
		this.add(salaryTextField);
		this.add(addButton);
		this.add(updateButton);
		this.add(saveButton);
		this.add(backButton);
		super.add(searchLabel);
		super.add(searchTextField);
		super.add(searchButton);
		super.add(deleteLabel);
		super.add(deleteTextField);
		super.add(deleteButton);
		super.add(clearButton);
		super.add(showAllButton);
		this.setVisible(true);
	}
	
	@Override
public void actionPerformed(ActionEvent ae) {
	
  if(ae.getActionCommand().equals("ADD")){
 System.out.println("ADD CLICKED");

if(
      !nameTextField.getText().isEmpty() &&
     !idTextField.getText().isEmpty() &&
       !ageTextField.getText().isEmpty() &&
       !shiftTextField.getText().isEmpty() &&
       !salaryTextField.getText().isEmpty()
           ){
 
  if( employeeList.getById(idTextField.getText()) == null){

    Employee e = new Employee(
      nameTextField.getText(),
  idTextField.getText(),
  ageTextField.getText(),
      shiftTextField.getText(),
 Integer.parseInt( salaryTextField.getText() )
   );

    employeeList.insert(e);
	//FileIO.insertInFile(employee.getEmployeeInfoAsString() );//, "./Files/books.txt");
FileIO.writeEmployeeInFile(e);

  reloadAllEmployees();
}
else{
JOptionPane.showMessageDialog(this,"This ID is Already in use, Provide Another ID","Provide Unique ID",JOptionPane.ERROR_MESSAGE);}
}
else{
JOptionPane.showMessageDialog(this,"Please Provide all Information for the Employee","Missing Information",JOptionPane.ERROR_MESSAGE);
}
}
else if(updateButton == ae.getSource()){
System.out.println("UPDATE CLICKED");
if(!idTextField.getText().isEmpty() ){
Employee e = employeeList.getById(idTextField.getText());
if(e!=null){
if(!nameTextField.getText().isEmpty()){
e.setName(nameTextField.getText());
}

if(!ageTextField.getText().isEmpty()){
e.setAge(ageTextField.getText());
}

if(!shiftTextField.getText().isEmpty()){
e.setShift(shiftTextField.getText());
}

if(!salaryTextField.getText().isEmpty()){
e.setSalary( Integer.parseInt( salaryTextField.getText() ));
}

FileIO.updateEmployeesInFile(employeeList);

reloadAllEmployees();
}
else{
JOptionPane.showMessageDialog(this,"No Available Employee by This ID","Employee Not Found",JOptionPane.ERROR_MESSAGE);
}
}
else{
JOptionPane.showMessageDialog(this,"Please Provide ID for the Employee","Missing Information",JOptionPane.ERROR_MESSAGE);
}

}
else if(searchButton == ae.getSource()){
System.out.println("SEARCH CLICKED");

Employee e = employeeList.getById(searchTextField.getText());
if(e!=null){
textArea.setText( e.getEmployeeInfoAsString() );
}
else{

JOptionPane.showMessageDialog(this,"NO Employee FOUND.","Alert",JOptionPane.WARNING_MESSAGE);
}

 

}
else if(deleteButton == ae.getSource()){
System.out.println("DELETE CLICKED");
employeeList.deleteById(deleteTextField.getText());
	 reloadAllEmployees();
}
else if(showAllButton == ae.getSource()){
System.out.println("SHOW ALL CLICKED");
textArea.setText( employeeList.getAll() );
	  reloadAllEmployees();
//textArea.setText( employeeList.getAllEmployee() );
}
else if(clearButton == ae.getSource()){
System.out.println("CLEAR CLICKED");
textArea.setText("");
}


else if(saveButton == ae.getSource()){
	System.out.println("saveButton CLICKED");
			FileIO.saveEmployeesInFile(employeeList);
		}
		else if(backButton == ae.getSource()){
	System.out.println("backButton CLICKED");
		HomePageGUI hpGUI= new HomePageGUI();
		}

}
public void reloadAllEmployees(){
		textArea.setText(employeeList.getAll());
	}

}


