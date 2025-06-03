package GUI;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import Entity.*;
import EntityList.*;
import java.io.*;
import File.FileIO;

public class StaffManagementGUI extends JFrame implements ActionListener{
	Font titleFont = new Font("Aria;",Font.BOLD,30);
	Font titleLabel = new Font("Arial",Font.BOLD,15);
	JTextField  idTextField,nameTextField,ageTextField,salaryTextField,searchTextField,deleteTextField;
	JButton addButton,updateButton,searchButton,deleteButton,clearButton,showAllButton,backButton,saveButton;
	JTextArea textArea;
	
	
	StaffList StaffList;
	public StaffManagementGUI(StaffList StaffList){
		super("One-Stop Gaming");
		
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize(850,700); //width, height
		this.setLocation(250,0); //x, y
		this.getContentPane().setBackground(new Color(48, 132, 173));
		this.setLayout(null);
		this.StaffList=StaffList;
		//============= Title ===========
		JLabel title = new JLabel("One-Stop Gaming");
		title.setBounds(300,10,500,50); //X,Y,W,H
		title.setFont(titleFont);
		//============Sub Title===========
		JLabel subTitle = new JLabel("Stafflist");
		subTitle.setBounds(400,60,320,50); //X,Y,W,H
		subTitle.setFont(new Font("Arial",Font.BOLD,25));

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
		JLabel searchLabel = new JLabel("Search By Staff ID");
		searchLabel.setBounds(600,top,200,30); //X,Y,W,H
		searchLabel.setFont(titleLabel);
		searchTextField = new JTextField();
		searchTextField.setBounds(600,top+=gap,200,30); //X,Y,W,H
		searchTextField.setFont(titleLabel);
		searchButton = new JButton("SEARCH");
		searchButton.setBounds(600,top+=gap,200,30); //X,Y,W,H
		searchButton.setBackground(new Color(165, 201, 202));
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
		deleteButton.setBackground(new Color(165, 201, 202));
		deleteButton.setForeground(Color.BLACK);
		deleteButton.setFont(titleLabel);
		deleteButton.addActionListener(this);
		
		
		backButton = new JButton("<= Back");
		backButton.setBounds(600,500,200,30);		
		backButton.setBackground(new Color(165, 201, 202));
		backButton.setForeground(Color.BLACK);
		backButton.addActionListener(this);
		
		saveButton = new JButton("SAVE");
		saveButton.setBounds(600,550,200,30);		
		saveButton.setBackground(new Color(165, 201, 202));
		saveButton.setForeground(Color.BLACK);
		saveButton.addActionListener(this);
		
		
		///////////////// Show All  information ///////////////
		showAllButton = new JButton("SHOW ALL Staff");
		showAllButton.setBounds(600,355,200,30); //X,Y,W,H
		showAllButton.setBackground(new Color(165, 201, 202));
		showAllButton.setForeground(Color.BLACK);
		showAllButton.setFont(titleLabel);
		showAllButton.addActionListener(this);
		///////////////// Clear Screen ///////////////
		clearButton = new JButton("CLEAR SCREEN");
		clearButton.setBounds(600,400,200,30); //X,Y,W,H
		clearButton.setBackground(new Color(165, 201, 202));
		clearButton.setForeground(Color.BLACK);
		clearButton.setFont(titleLabel);
		clearButton.addActionListener(this);
				
		
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
		addButton.setBackground(new Color(165, 201, 202));
		addButton.setFont(titleLabel);
		addButton.addActionListener(this);
		updateButton = new JButton("UPDATE");
		updateButton.setBounds(20,top+=gap,200,30); //X,Y,W,H
		updateButton.setBackground(new Color(165, 201, 202));
		updateButton.setForeground(Color.BLACK);
		updateButton.setFont(titleLabel);
		updateButton.addActionListener(this);

		//=========== DISPLAY  AREA ===========
		textArea = new JTextArea();
		//textArea.setBounds(0,0,300,500);
		textArea.setFont(titleLabel );
		reloadAllStaffs();
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
	       !salaryTextField.getText().isEmpty()
	  ){
	 
	  if( StaffList.getById(idTextField.getText()) == null){

	    Staff e = new Staff(
	      nameTextField.getText(),
	  idTextField.getText(),
	  ageTextField.getText(),
	 Integer.parseInt( salaryTextField.getText() )
	   );

	    StaffList.insert(e);
		//FileIO.insertInFile(Staff.getStaffInfoAsString() );//, "./Files/books.txt");
	FileIO.writeStaffInFile(e);

	  reloadAllStaffs();
	}
	else{
	JOptionPane.showMessageDialog(this,"This ID is Already in use, Provide Another ID","Provide Unique ID",JOptionPane.ERROR_MESSAGE);}
	}
	else{
	JOptionPane.showMessageDialog(this,"Please Provide all Information for the Staff","Missing Information",JOptionPane.ERROR_MESSAGE);
	}
	}
	else if(updateButton == ae.getSource()){
	System.out.println("UPDATE CLICKED");
	if(!idTextField.getText().isEmpty() ){
	Staff e = StaffList.getById(idTextField.getText());
	if(e!=null){
	if(!nameTextField.getText().isEmpty()){
	e.setName(nameTextField.getText());
	}

	if(!ageTextField.getText().isEmpty()){
	e.setAge(ageTextField.getText());
	}

	if(!salaryTextField.getText().isEmpty()){
	e.setSalary( Integer.parseInt( salaryTextField.getText() ));
	}

	FileIO.updateStaffsInFile(StaffList);

	reloadAllStaffs();
	}
	else{
	JOptionPane.showMessageDialog(this,"No Available Staff by This ID","Staff Not Found",JOptionPane.ERROR_MESSAGE);
	}
	}
	else{
	JOptionPane.showMessageDialog(this,"Please Provide ID for the Staff","Missing Information",JOptionPane.ERROR_MESSAGE);
	}

	}
	else if(searchButton == ae.getSource()){
	System.out.println("SEARCH CLICKED");

	Staff e = StaffList.getById(searchTextField.getText());
	if(e!=null){
	textArea.setText( e.getStaffInfoAsString() );
	}
	else{

	JOptionPane.showMessageDialog(this,"NO Staff FOUND.","Alert",JOptionPane.WARNING_MESSAGE);
	}

	 

	}
	else if(deleteButton == ae.getSource()){
	System.out.println("DELETE CLICKED");
	StaffList.deleteById(deleteTextField.getText());
		 reloadAllStaffs();
	}
	else if(showAllButton == ae.getSource()){
	System.out.println("SHOW ALL CLICKED");
	textArea.setText( StaffList.getAll() );
		  reloadAllStaffs();
	//textArea.setText( StaffList.getAllStaff() );
	}
	else if(clearButton == ae.getSource()){
	System.out.println("CLEAR CLICKED");
	textArea.setText("");
	}


	else if(saveButton == ae.getSource()){
		System.out.println("saveButton CLICKED");
				FileIO.saveStaffsInFile(StaffList);
			}
			else if(backButton == ae.getSource()){
		System.out.println("backButton CLICKED");
			HomePageGUI hpGUI= new HomePageGUI();
			}

	}
	
	public void reloadAllStaffs(){
		textArea.setText(StaffList.getAll());
	}
}


