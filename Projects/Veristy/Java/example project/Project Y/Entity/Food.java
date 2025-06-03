package Entity;

public class Food{
	
		private String foodCode;
		private String foodName;
		private String foodSize;
		private String foodType;
		private int foodPrice;
		
		public Food(){}
		public Food(String foodCode,String foodName,String foodSize,String foodType,int foodPrice){
			this.foodCode=foodCode;
			this.foodName=foodName;
			this.foodSize=foodSize;
			this.foodType=foodType;			
			this.foodPrice=foodPrice;
		}
		
		public void setFoodName(String foodName){this.foodName=foodName;}
		public void setFoodCode(String foodCode){this.foodCode=foodCode;}
		public void setFoodType(String foodType){this.foodType=foodType;}
		public void setFoodSize(String foodSize){this.foodSize=foodSize;}
		public void setFoodPrice(int foodPrice){this.foodPrice=foodPrice;}
	
		
		public String getFoodName(){return this.foodName;}
		public String getFoodCode(){return this.foodCode;}
		public String getFoodType(){return this.foodType;}
		public String getFoodSize(){return this.foodSize;}
		public int getFoodPrice(){return this.foodPrice;}
		
		public void showFoodInfo(){
			System.out.println("Food code : "+this.foodCode);
			System.out.println("Name : "+this.foodName);
			System.out.println("Size : "+this.foodSize);
			System.out.println("Food Type : "+this.foodType);
			System.out.println("PRICE : "+this.foodPrice);
		}
		
		public String getFoodInfoAsString(){
		
		
		return 
		        "Code : "+foodCode+"\n"+
				"Name : "+foodName+"\n"+
				"Size : "+foodSize+"\n"+
				"Type : "+foodType+"\n"+
				"Price : "+foodPrice+"\n";
				
	}
	
	
}