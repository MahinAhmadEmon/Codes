package File;
import java.io.*;
import java.util.Scanner;
import Entity.*;
import EntityList.*;
public class PFileIO{
	public static void loadProductsFromFile(ProductMenu ProductMenu){
		try{
			Scanner sc = new Scanner(new File("./File/products.txt"));
			while(sc.hasNextLine()){
				String data[] = sc.nextLine().split(";");
				Product f = new Product(data[0],data[1],data[2],Integer.parseInt(data[3]));
				ProductMenu.insert(f);
			}
			sc.close();
		}
		catch(Exception e){
			
		}
	}
	
	public static void writeProductInFile(Product f){
		try{
			FileWriter writer = new FileWriter(new File("./File/products.txt"),true);
			String data = f.getProductCode()+";"+f.getProductName()+";"+f.getProductType()+";"+
						  f.getProductPrice()+"\n";
			writer.write(data);
			writer.close();
		}
		catch(Exception e){
			
		}
	}
	
	public static void updateProductsInFile(ProductMenu ProductMenu){
		try{
			FileWriter writer = new FileWriter(new File("./File/products.txt"));
			Product Products[] = ProductMenu.getAllProducts();
			
			String allData="";
			
			for(int i=0;i<Products.length;i++){
				if(Products[i]!=null){
					String data = Products[i].getProductCode()+";"+Products[i].getProductName()+";"+Products[i].getProductType()+";"+
						  Products[i].getProductPrice()+"\n";
					
					allData+=data;
				}
			}
			writer.write(allData);
			writer.close();
		}
		catch(Exception e){
			
		}
	}

	
	public static void saveProductsInFile(ProductMenu ProductMenu){
		try {
		FileWriter writer = new FileWriter(new File("./File/products.txt"));
			Product Products[] = ProductMenu.getAllProducts();
			
			String allData="";
			for(int i=0;i<Products.length;i++){
				if(Products[i]!=null){
					String data = Products[i].getProductCode()+";"+Products[i].getProductName()+";"+Products[i].getProductType()+";"+
						  Products[i].getProductPrice()+"\n";
					
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