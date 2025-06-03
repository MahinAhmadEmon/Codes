package EntityList;
import Entity.*;
import Interfaces.*;
public class FoodMenu implements IFoodMenu{
    private Food foods[];

    public FoodMenu() {
        foods = new Food[50];
    }

    public FoodMenu(int size) {
        foods = new Food[size];
    }


    public void insert(Food f) {
        boolean flag = false;
        for (int i = 0; i < foods.length; i++) {
            if (foods[i] == null) {
                foods[i] = f;
                flag = true;
                break;
            }
        }
        if (flag) {
            System.out.println("Food Inserted");
        } else {
            System.out.println("Insertion Failed");
        }
    }


    public Food getByCode(String code) {
        for (int i = 0; i < foods.length; i++) {
            if (foods[i] != null) {
                if (foods[i].getFoodCode().equals(code)) {
                    return foods[i];
                }
            }
        }
        return null;
    }

    public void deleteByCode(String code) {
        boolean flag = false;
        for (int i = 0; i < foods.length; i++) {
            if (foods[i] != null) {
                if (foods[i].getFoodCode().equals(code)) {
                    foods[i] = null;
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
        for (int i = 0; i < foods.length; i++) {
            if (foods[i] != null) {
                if (foods[i].getFoodName().equals(name)) {
                    System.out.println("Food Found");
                    foods[i].showFoodInfo();
                    return;
                }
            }
        }
        System.out.println("-- Food Not Found ---");
    }

    public void showAll() {
        System.out.println("-------------Available Foods-----------");
        for (int i = 0; i < foods.length; i++) {
            if (foods[i] != null) {
                System.out.println("---------------------");
                foods[i].showFoodInfo();
            }
        }
        System.out.println("---------------------");
    }

	public String getAll(){
		String allFoodInfo = "";
		for(int i=0;i<foods.length;i++){
			if(foods[i] != null){ 
			
				allFoodInfo += "-----------------  \n";
				allFoodInfo += foods[i].getFoodInfoAsString();
			
			}
		}
		allFoodInfo += "----------------------------------------\n";
		return allFoodInfo;
	}
	
	
	public Food[] getAllFoods(){return foods;}
	
}