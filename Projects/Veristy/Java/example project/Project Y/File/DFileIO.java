package File;
import java.io.*;
import java.util.Scanner;
import Entity.*;
import EntityList.*;
public class DFileIO{
	public static void loadDrinksFromFile(DrinkMenu drinkMenu){
		try{
			Scanner sc = new Scanner(new File("./File/drinks.txt"));
			while(sc.hasNextLine()){
				String data[] = sc.nextLine().split(";");
				Drink d = new Drink(data[0],data[1],data[2],data[3],Integer.parseInt(data[4]),data[5]);
				drinkMenu.insert(d);
			}
			sc.close();
		}
		catch(Exception e){
			
		}
	}
	
	public static void writeDrinkInFile(Drink d){
		try{
			FileWriter writer = new FileWriter(new File("./File/drinks.txt"),true);
			String data = d.getFoodCode()+";"+d.getFoodName()+";"+
						  d.getFoodSize()+";"+d.getFoodType()+";"+
						  d.getFoodPrice()+";"+d.getAmount()+"\n";
			writer.write(data);
			writer.close();
		}
		catch(Exception e){
			
		}
	}
	
	public static void updateDrinksInFile(DrinkMenu drinkMenu){
		try{
			FileWriter writer = new FileWriter(new File("./File/drinks.txt"));
			Drink drinks[] = drinkMenu.getAllDrinks();
			
			String allData="";
			
			for(int i=0;i<drinks.length;i++){
				if(drinks[i]!=null){
					String data = drinks[i].getFoodCode()+";"+drinks[i].getFoodName()+";"+
						  drinks[i].getFoodSize()+";"+drinks[i].getFoodType()+";"+
						  drinks[i].getFoodPrice()+";"+drinks[i].getAmount()+"\n";
					
					allData+=data;
				}
			}
			writer.write(allData);
			writer.close();
		}
		catch(Exception e){
			
		}
	}
		
	public static void saveDrinksInFile(DrinkMenu drinkMenu){
		try {
		FileWriter writer = new FileWriter(new File("./File/drinks.txt"));
			Drink drinks[] = drinkMenu.getAllDrinks();
			
			String allData="";
			for(int i=0;i<drinks.length;i++){
				if(drinks[i]!=null){
					String data = drinks[i].getFoodCode()+";"+drinks[i].getFoodName()+";"+
						  drinks[i].getFoodSize()+";"+drinks[i].getFoodType()+";"+
						  drinks[i].getFoodPrice()+";"+drinks[i].getAmount()+"\n";
					
					allData+=data;
				}
			}
			writer.write(allData);
			writer.close();
		} catch (IOException e) {
			System.out.println("Cannot Write in File");
		}
	}
}