package Entity;

public class Product{
	
		private String ProductCode;
		private String ProductName;
		private String ProductType;
		private int ProductPrice;
		
		public Product(){}
		public Product(String ProductCode,String ProductName,String ProductType,int ProductPrice){
			this.ProductCode=ProductCode;
			this.ProductName=ProductName;
			this.ProductType=ProductType;			
			this.ProductPrice=ProductPrice;
		}
		
		public void setProductName(String ProductName){this.ProductName=ProductName;}
		public void setProductCode(String ProductCode){this.ProductCode=ProductCode;}
		public void setProductType(String ProductType){this.ProductType=ProductType;}
		public void setProductPrice(int ProductPrice){this.ProductPrice=ProductPrice;}
	
		
		public String getProductName(){return this.ProductName;}
		public String getProductCode(){return this.ProductCode;}
		public String getProductType(){return this.ProductType;}
		public int getProductPrice(){return this.ProductPrice;}
		
		public void showProductInfo(){
			System.out.println("Product code : "+this.ProductCode);
			System.out.println("Name : "+this.ProductName);
			System.out.println("Product Type : "+this.ProductType);
			System.out.println("Price(Taka) : "+this.ProductPrice);
		}
		
		public String getProductInfoAsString(){
		
		
		return 
		        "Code : "+ProductCode+"\n"+
				"Name : "+ProductName+"\n"+
				"Type : "+ProductType+"\n"+
				"Price(Taka) : "+ProductPrice+"\n";
				
	}
	
	
}