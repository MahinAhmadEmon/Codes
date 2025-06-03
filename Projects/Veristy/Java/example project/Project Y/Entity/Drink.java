package Entity ;
public class Drink extends Food{
	private String amount;
	public Drink(){}
	public Drink(String foodCode,String foodName,String foodSize,String foodType,int foodPrice,String amount){
		super(foodCode,foodName,foodSize,foodType,foodPrice);
		this.amount=amount;
	}
 
	public void setAmount(String amount){
		this.amount=amount;
	}
	
	public String getAmount(){
		return this.amount;
	}
	
	@Override
	public void showFoodInfo(){
		super.showFoodInfo();
		System.out.println("Amount : "+this.amount);
	}
    public String getDrinkInfoAsString() {
        return super.getFoodInfoAsString() +
                "Amount: " + amount + "\n";
    }
} 