package Interfaces;
import Entity.*;

import java.util.Scanner;

public interface IProductMenu{
	void insert(Product f);
	Product getByCode(String code);
	void deleteByCode(String code);
	void searchByName(String name);
	void showAll();
}