package Interfaces;
import Entity.*;

import java.util.Scanner;

public interface IGameMenu{
	void insert(Game f);
	Game getByCode(String code);
	void deleteByCode(String code);
	void searchByName(String name);
	void showAll();
}