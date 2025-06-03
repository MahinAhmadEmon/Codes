package EntityList;
import Entity.*;
//import Interfaces.*;

public class DrinkMenu /*implements IDrinkMenu*/ {
    private Drink drinks[];

    public DrinkMenu() {
        drinks = new Drink[50];
    }

    public DrinkMenu(int size) {
        drinks = new Drink[size];
    }

    public void insert(Drink d) {
        boolean flag = false;
        for (int i = 0; i < drinks.length; i++) {
            if (drinks[i] == null) {
                drinks[i] = d;
                flag = true;
                break;
            }
        }
        if (flag) {
            System.out.println("Drink Inserted");
        } else {
            System.out.println("Insertion Failed");
        }
    }

    public Drink getByCode(String code) {
        for (int i = 0; i < drinks.length; i++) {
            if (drinks[i] != null) {
                if (drinks[i].getFoodCode().equals(code)) {
                    return drinks[i];
                }
            }
        }
        return null;
    }

    public void deleteByCode(String code) {
        boolean flag = false;
        for (int i = 0; i < drinks.length; i++) {
            if (drinks[i] != null) {
                if (drinks[i].getFoodCode().equals(code)) {
                    drinks[i] = null;
                    flag = true;
                    break;
                }
            }
        }
        if (flag) {
            System.out.println("Deleted");
        } else {
            System.out.println("Failed");
        }
    }

    public void searchByName(String name) {
        for (int i = 0; i < drinks.length; i++) {
            if (drinks[i] != null) {
                if (drinks[i].getFoodName().equals(name)) {
                    System.out.println("Drink Found");
                    drinks[i].showFoodInfo();
                    return;
                }
            }
        }
        System.out.println("-- Drink Not Found ---");
    }

    public void showAll() {
        System.out.println("-------------Available Drinks-----------");
        for (int i = 0; i < drinks.length; i++) {
            if (drinks[i] != null) {
                System.out.println("---------------------");
                drinks[i].showFoodInfo();
            }
        }
        System.out.println("---------------------");
    }

   public String getAll() {
    String allDrinkInfo = "";
    for (int i = 0; i < drinks.length; i++) {
        if (drinks[i] != null) {
            allDrinkInfo += "-----------------  \n";
            allDrinkInfo += drinks[i].getDrinkInfoAsString();  // This line is causing the issue
        }
    }
    allDrinkInfo += "----------------------------------------\n";
    return allDrinkInfo;
}

    public Drink[] getAllDrinks() {
        return drinks;
    }
}