package Interfaces;
import Entity.Employee;
import java.util.Scanner;
public interface IEmplooyeeList{
	void insert(Employee e);
	Employee getById(String id);
	void deleteById(String id);
	void searchByName(String name);
	void showAll();
	
}