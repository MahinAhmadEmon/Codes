package File;
import java.io.*;
import java.util.Scanner;
import Entity.*;
import EntityList.*;
public class FileIO{
	public static void loadEmployeesFromFile(EmployeeList employeeList){
		try{
			Scanner sc = new Scanner(new File("./File/employees.txt"));
			while(sc.hasNextLine()){
				String data[] = sc.nextLine().split(";");
				Employee e = new Employee(data[0],data[1],data[2],data[3],Integer.parseInt(data[4]));
				employeeList.insert(e);
			}
			sc.close();
		}
		catch(Exception e){
			
		}
	}
	
	public static void writeEmployeeInFile(Employee e){
		try{
			FileWriter writer = new FileWriter(new File("./File/employees.txt"),true);
			String data = e.getName()+";"+e.getId()+";"+
						  e.getAge()+";"+e.getShift()+";"+
						  e.getSalary()+"\n";
			writer.write(data);
			writer.close();
		}
		catch(Exception ex){
			
		}
	}
	
	public static void updateEmployeesInFile(EmployeeList employeeList){
		try{
			FileWriter writer = new FileWriter(new File("./File/employees.txt"));
			Employee employees[] = employeeList.getAllEmployee();
			
			String allData="";
			
			for(int i=0;i<employees.length;i++){
				if(employees[i]!=null){
					String data = employees[i].getName()+";"+employees[i].getId()+";"+
						  employees[i].getAge()+";"+employees[i].getShift()+";"+
						  employees[i].getSalary()+"\n";
					
					allData+=data;
				}
			}
			writer.write(allData);
			writer.close();
		}
		catch(Exception ex){
			
		}
	}

	
	public static void saveEmployeesInFile(EmployeeList employeeList){
		try {
		FileWriter writer = new FileWriter(new File("./File/employees.txt"));
			Employee employees[] = employeeList.getAllEmployee();
			
			String allData="";
			for(int i=0;i<employees.length;i++){
				if(employees[i]!=null){
					String data = employees[i].getName()+";"+employees[i].getId()+";"+
						  employees[i].getAge()+";"+employees[i].getShift()+";"+
						  employees[i].getSalary()+"\n";
					
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
