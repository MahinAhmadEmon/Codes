package EntityList;
import Entity.*;
import Interfaces.*;
public class ProductMenu implements IProductMenu{
    private Product Products[];

    public ProductMenu() {
        Products = new Product[50];
    }

    public ProductMenu(int size) {
        Products = new Product[size];
    }


    public void insert(Product f) {
        boolean flag = false;
        for (int i = 0; i < Products.length; i++) {
            if (Products[i] == null) {
                Products[i] = f;
                flag = true;
                break;
            }
        }
        if (flag) {
            System.out.println("Product Inserted");
        } else {
            System.out.println("Insertion Failed");
        }
    }


    public Product getByCode(String code) {
        for (int i = 0; i < Products.length; i++) {
            if (Products[i] != null) {
                if (Products[i].getProductCode().equals(code)) {
                    return Products[i];
                }
            }
        }
        return null;
    }

    public void deleteByCode(String code) {
        boolean flag = false;
        for (int i = 0; i < Products.length; i++) {
            if (Products[i] != null) {
                if (Products[i].getProductCode().equals(code)) {
                    Products[i] = null;
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
        for (int i = 0; i < Products.length; i++) {
            if (Products[i] != null) {
                if (Products[i].getProductName().equals(name)) {
                    System.out.println("Product Found");
                    Products[i].showProductInfo();
                    return;
                }
            }
        }
        System.out.println("-- Product Not Found ---");
    }

    public void showAll() {
        System.out.println("-------------Available Products-----------");
        for (int i = 0; i < Products.length; i++) {
            if (Products[i] != null) {
                System.out.println("---------------------");
                Products[i].showProductInfo();
            }
        }
        System.out.println("---------------------");
    }

	public String getAll(){
		String allProductInfo = "";
		for(int i=0;i<Products.length;i++){
			if(Products[i] != null){ 
			
				allProductInfo += "-----------------  \n";
				allProductInfo += Products[i].getProductInfoAsString();
			
			}
		}
		allProductInfo += "----------------------------------------\n";
		return allProductInfo;
	}
	
	
	public Product[] getAllProducts(){return Products;}
	
}