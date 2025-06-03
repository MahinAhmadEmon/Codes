package Interfaces;
import Entity.*;

import java.util.Scanner;

public interface IFoodMenu{
	void insert(Food f);
	Food getByCode(String code);
	void deleteByCode(String code);
	void searchByName(String name);
	 void showAll();
	
	
}