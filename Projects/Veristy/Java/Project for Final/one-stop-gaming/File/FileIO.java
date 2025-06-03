package File;
import java.io.*;
import java.util.Scanner;
import Entity.*;
import EntityList.*;
public class FileIO{
	public static void loadStaffsFromFile(StaffList StaffList){
		try{
			Scanner sc = new Scanner(new File("./File/staffs.txt"));
			while(sc.hasNextLine()){
				String data[] = sc.nextLine().split(";");
				Staff e = new Staff(data[0],data[1],data[2],Integer.parseInt(data[3]));
				StaffList.insert(e);
			}
			sc.close();
		}
		catch(Exception e){
			
		}
	}
	
	public static void writeStaffInFile(Staff e){
		try{
			FileWriter writer = new FileWriter(new File("./File/staffs.txt"),true);
			String data = e.getName()+";"+e.getId()+";"+
						  e.getAge()+";"+
						  e.getSalary()+"\n";
			writer.write(data);
			writer.close();
		}
		catch(Exception ex){
			
		}
	}
	
	public static void updateStaffsInFile(StaffList StaffList){
		try{
			FileWriter writer = new FileWriter(new File("./File/staffs.txt"));
			Staff Staffs[] = StaffList.getAllStaff();
			
			String allData="";
			
			for(int i=0;i<Staffs.length;i++){
				if(Staffs[i]!=null){
					String data = Staffs[i].getName()+";"+Staffs[i].getId()+";"+
						  Staffs[i].getAge()+";"+
						  Staffs[i].getSalary()+"\n";
					
					allData+=data;
				}
			}
			writer.write(allData);
			writer.close();
		}
		catch(Exception ex){
			
		}
	}

	
	public static void saveStaffsInFile(StaffList StaffList){
		try {
		FileWriter writer = new FileWriter(new File("./File/staffs.txt"));
			Staff Staffs[] = StaffList.getAllStaff();
			
			String allData="";
			for(int i=0;i<Staffs.length;i++){
				if(Staffs[i]!=null){
					String data = Staffs[i].getName()+";"+Staffs[i].getId()+";"+
						  Staffs[i].getAge()+";"+
						  Staffs[i].getSalary()+"\n";
					
					allData+=data;
				}
			}
			writer.write(allData);
			writer.close();
		} catch (IOException ex) {
			System.out.println("Cannot Write in File");
		}
	}
}
