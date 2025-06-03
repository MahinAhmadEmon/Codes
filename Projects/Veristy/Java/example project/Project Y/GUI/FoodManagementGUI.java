package GUI;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import Entity.*;
import EntityList.*;
import File.FFileIO;

public class FoodManagementGUI extends JFrame implements ActionListener{
	Font titleFont = new Font("Algerian",Font.BOLD,30);
	Font titleLabel = new Font("Cambria",Font.BOLD,15);
	
	JTextField codeTextField,nameTextField,sizeTextField,typeTextField,priceTextField;
	JTextField searchTextField,deleteTextField;
	JButton addButton,updateButton,searchButton,deleteButton,clearButton,showAllButton,backButton,saveButton;
	JTextArea textArea;
	FoodMenu foodMenu;
	public FoodManagementGUI(FoodMenu foodMenu){
		super("Malvolent Kitchen");
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize(850,700); //width, hthis
		this.setLocation(250,0); //x, y
		this.getContentPane().setBackground(new Color(255,255,153));
		this.setLayout(null);
		this.foodMenu=foodMenu;
		//============= Title ===========
		JLabel title = new JLabel("Malvolent Kitchen!");
		title.setBounds(300,10,500,50); //X,Y,W,H
		title.setFont(titleFont);
		//============Sub Title===========
		JLabel subTitle = new JLabel("Menu");
		subTitle.setBounds(400,60,320,50); //X,Y,W,H
		subTitle.setFont(new Font("Cambria",Font.BOLD,25));
		
		
		//============ Entry Form ===========
		int top = 100;
		int gap = 40;
		//=========== code Entry  ===========
		JLabel codeLabel = new JLabel("Food Code");
		codeLabel.setBounds(20,top,200,30); //X,Y,W,H
		codeLabel.setFont(titleLabel);
		
		codeTextField = new JTextField();
		codeTextField.setBounds(20,top+=gap,200,30); //X,Y,W,H
		codeTextField.setFont(titleLabel);
		
		
		JLabel nameLabel = new JLabel("Food Name");
		nameLabel.setBounds(20,top+=gap,200,30); //X,Y,W,H
		nameLabel.setFont(titleLabel);
		
		nameTextField = new JTextField();
		nameTextField.setBounds(20,top+=gap,200,30); //X,Y,W,H
		nameTextField.setFont(titleLabel);
		

		JLabel sizeLabel = new JLabel("Food Size");
	    sizeLabel.setBounds(20,top+=gap,200,30); //X,Y,W,H
		sizeLabel.setFont(titleLabel);
		
		sizeTextField = new JTextField();
		sizeTextField.setBounds(20,top+=gap,200,30); //X,Y,W,H
		sizeTextField.setFont(titleLabel);
		

		JLabel typeLabel = new JLabel("Food Type");
		typeLabel.setBounds(20,top+=gap,200,30); //X,Y,W,H
		typeLabel.setFont(titleLabel);
		
		typeTextField = new JTextField();
		typeTextField.setBounds(20,top+=gap,200,30); //X,Y,W,H
		typeTextField.setFont(titleLabel);
		
		
		JLabel priceLabel = new JLabel("Food Price");
		priceLabel.setBounds(20,top+=gap,200,30); //X,Y,W,H
		priceLabel.setFont(titleLabel);
		
		priceTextField = new JTextField();
		priceTextField.setBounds(20,top+=gap,200,30); //X,Y,W,H
		priceTextField.setFont(titleLabel);
		
	
		
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
		
		
		//============ INFORMATION DISPLAY  AREA ===========
		textArea = new JTextArea();
		textArea.setFont(titleLabel );
		textArea.setEditable(false);
		

	    reloadAllFoods();
		JScrollPane jsp =
        new JScrollPane(textArea);
		jsp.setBounds(280,120,300,500);
		this.add(jsp);
		
				top = 100;
		gap = 40;
		//============Search Entry  ===========
		JLabel searchLabel = new JLabel("Search By Food Code:");
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
		JLabel deleteLabel = new JLabel("Delete By Food ID");
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
		
		
		
		
		///////////////// Show All information ///////////////
		
		showAllButton = new JButton("SHOW ALL Food");
		showAllButton.setBounds(600,400,200,30); //X,Y,W,H
		showAllButton.setBackground(Color.PINK);
		showAllButton.setForeground(Color.WHITE);
		showAllButton.setFont(titleLabel);
		showAllButton.addActionListener(this);
		
		///////////////// Clear Screen ///////////////
		
		clearButton = new JButton("CLEAR SCREEN");
		clearButton.setBounds(600,450,200,30); //X,Y,W,H
		clearButton.setBackground(Color.DARK_GRAY);
		clearButton.setForeground(Color.WHITE);
		clearButton.setFont(titleLabel);
		clearButton.addActionListener(this);
		
		backButton = new JButton("Home Page");
		backButton.setBounds(600,500,200,30);
		backButton.setBackground(Color.BLACK);
		backButton.setForeground(Color.WHITE);
		backButton.addActionListener(this);
		

		saveButton = new JButton("SAVE");
		saveButton.setBounds(600,550,200,30);
		saveButton.setBackground(Color.ORANGE);
		saveButton.setForeground(Color.WHITE);
		saveButton.addActionListener(this);
		
		
		
		this.add(title);
		this.add(subTitle);
		this.add(codeLabel);
		this.add(codeTextField);
		this.add(nameLabel);
		this.add(nameTextField);
		this.add(sizeLabel);
		this.add(sizeTextField);
		this.add(typeLabel);
		this.add(typeTextField);
		this.add(priceLabel);
		this.add(priceTextField);
		this.add(addButton);
		this.add(updateButton);
		this.add(searchLabel);
		this.add(searchTextField);
		this.add(searchButton);
		this.add(deleteLabel);
		this.add(deleteTextField);
		this.add(deleteButton);
		this.add(clearButton);
		this.add(showAllButton);
		this.add(backButton);
		this.add(saveButton);
		
		this.setVisible(true);
	}
	@Override
public void actionPerformed(ActionEvent e) {
    if (e.getSource() == addButton) {
        System.out.println("ADD CLICKED");
		if(
				!codeTextField.getText().isEmpty() &&
				!nameTextField.getText().isEmpty() &&
				!typeTextField.getText().isEmpty() &&
				!sizeTextField.getText().isEmpty() &&
				!priceTextField.getText().isEmpty()
			){
			if( foodMenu.getByCode(codeTextField.getText()) == null){
				Food f = new Food(
							
							codeTextField.getText(),
							nameTextField.getText(),
							
							sizeTextField.getText(),
							typeTextField.getText(),
						    Integer.parseInt( priceTextField.getText())
						);
					
					foodMenu.insert(f);
					//FFileIO.insertInFile(f.getFoodInfoAsString(), "./File/foods.txt");
					FFileIO.writeFoodInFile(f);

					
					reloadAllFoods();
			}	
			else{
					JOptionPane.showMessageDialog(this,"This ID Already Exists","Provide Unique ID",JOptionPane.ERROR_MESSAGE);
				}
			}
        else{
				JOptionPane.showMessageDialog(this,"Please Provide all Information for ","Missing Information",JOptionPane.ERROR_MESSAGE);
			}
    }
	
	else if (e.getSource() == updateButton) {
      
        System.out.println("UPDATE CLICKED");
  			if(!codeTextField.getText().isEmpty() ){
				Food f = foodMenu.getByCode(codeTextField.getText());
				if(f!=null){
					if(!nameTextField.getText().isEmpty()){
						f.setFoodName(nameTextField.getText());
					}
					
					if(!sizeTextField.getText().isEmpty()){
						f.setFoodSize(sizeTextField.getText());
					}
					
					if(!typeTextField.getText().isEmpty()){
						f.setFoodType(typeTextField.getText());
					}
					
					if(!priceTextField.getText().isEmpty()){
						f.setFoodPrice( Integer.parseInt( priceTextField.getText() ));
					}
					
					FFileIO.updateFoodsInFile(foodMenu);
					
					reloadAllFoods();
				}
				else{
					JOptionPane.showMessageDialog(this,"No Available Food ","Food Not Found",JOptionPane.ERROR_MESSAGE);
				}
			}
			else{
				JOptionPane.showMessageDialog(this,"Please Provide ID ","Missing Information",JOptionPane.ERROR_MESSAGE);
			}    
    }
	else if (e.getSource() == searchButton) {
    
        System.out.println("SEARCH CLICKED");
       Food f = foodMenu.getByCode(searchTextField.getText());
			if(f!=null){
				textArea.setText( f.getFoodInfoAsString() );
			}
			else{
				//textArea.setText( "NO BOOK FOUND" );
				JOptionPane.showMessageDialog(this,"NOT FOUND.","Alert",JOptionPane.WARNING_MESSAGE);
			}
    }
	else if (e.getSource() == deleteButton) {
       
        System.out.println("DELETE CLICKED");
     foodMenu.deleteByCode(deleteTextField.getText());
	 reloadAllFoods();
    }
	else if (e.getSource() == showAllButton) {
       
        System.out.println("SHOW ALL CLICKED");
      textArea.setText( foodMenu.getAll() );
	  reloadAllFoods();
    } 
	else if (e.getSource() == clearButton) {
       
        System.out.println("CLEAR CLICKED");
       textArea.setText("");
	   
    }
	else if(saveButton == e.getSource()){
		System.out.println("SAVE CLICKED");
			FFileIO.saveFoodsInFile(foodMenu);
		}
		else if(backButton == e.getSource()){
			System.out.println("HOMEPAGE CLICKED");
			HomePageGUI hpGUI= new HomePageGUI();
		}
	
 } 
 	public void reloadAllFoods(){
		textArea.setText(foodMenu.getAll());
	}
}