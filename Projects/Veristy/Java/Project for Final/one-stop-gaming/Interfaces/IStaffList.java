package Interfaces;
import Entity.Staff;
import java.util.Scanner;
public interface IStaffList{
	void insert(Staff e);
	Staff getById(String id);
	void deleteById(String id);
	void searchByName(String name);
	void showAll();
}