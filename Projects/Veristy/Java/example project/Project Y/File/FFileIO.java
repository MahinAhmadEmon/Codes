package File;
import java.io.*;
import java.util.Scanner;
import Entity.*;
import EntityList.*;
public class FFileIO{
	public static void loadFoodsFromFile(FoodMenu foodMenu){
		try{
			Scanner sc = new Scanner(new File("./File/foods.txt"));
			while(sc.hasNextLine()){
				String data[] = sc.nextLine().split(";");
				Food f = new Food(data[0],data[1],data[2],data[3],Integer.parseInt(data[4]));
				foodMenu.insert(f);
			}
			sc.close();
		}
		catch(Exception e){
			
		}
	}
	
	public static void writeFoodInFile(Food f){
		try{
			FileWriter writer = new FileWriter(new File("./File/foods.txt"),true);
			String data = f.getFoodCode()+";"+f.getFoodName()+";"+
						  f.getFoodSize()+";"+f.getFoodType()+";"+
						  f.getFoodPrice()+"\n";
			writer.write(data);
			writer.close();
		}
		catch(Exception e){
			
		}
	}
	
	public static void updateFoodsInFile(FoodMenu foodMenu){
		try{
			FileWriter writer = new FileWriter(new File("./File/foods.txt"));
			Food foods[] = foodMenu.getAllFoods();
			
			String allData="";
			
			for(int i=0;i<foods.length;i++){
				if(foods[i]!=null){
					String data = foods[i].getFoodCode()+";"+foods[i].getFoodName()+";"+
						  foods[i].getFoodSize()+";"+foods[i].getFoodType()+";"+
						  foods[i].getFoodPrice()+"\n";
					
					allData+=data;
				}
			}
			writer.write(allData);
			writer.close();
		}
		catch(Exception e){
			
		}
	}

	
	public static void saveFoodsInFile(FoodMenu foodMenu){
		try {
		FileWriter writer = new FileWriter(new File("./File/foods.txt"));
			Food foods[] = foodMenu.getAllFoods();
			
			String allData="";
			for(int i=0;i<foods.length;i++){
				if(foods[i]!=null){
					String data = foods[i].getFoodCode()+";"+foods[i].getFoodName()+";"+
						  foods[i].getFoodSize()+";"+foods[i].getFoodType()+";"+
						  foods[i].getFoodPrice()+"\n";
					
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