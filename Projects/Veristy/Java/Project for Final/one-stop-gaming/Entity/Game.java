package Entity;

public class Game{
	
		private String GameCode;
		private String GameName;
		private String GameGenre;
		private String GameType;
		private int GamePrice;
		
		public Game(){}
		public Game(String GameCode,String GameName,String GameGenre,String GameType,int GamePrice){
			this.GameCode=GameCode;
			this.GameName=GameName;
			this.GameGenre=GameGenre;
			this.GameType=GameType;			
			this.GamePrice=GamePrice;
		}
		
		public void setGameName(String GameName){this.GameName=GameName;}
		public void setGameCode(String GameCode){this.GameCode=GameCode;}
		public void setGameType(String GameType){this.GameType=GameType;}
		public void setGameGenre(String GameGenre){this.GameGenre=GameGenre;}
		public void setGamePrice(int GamePrice){this.GamePrice=GamePrice;}
	
		
		public String getGameName(){return this.GameName;}
		public String getGameCode(){return this.GameCode;}
		public String getGameType(){return this.GameType;}
		public String getGameGenre(){return this.GameGenre;}
		public int getGamePrice(){return this.GamePrice;}
		
		public void showGameInfo(){
			System.out.println("Game code : "+this.GameCode);
			System.out.println("Name : "+this.GameName);
			System.out.println("Size : "+this.GameGenre);
			System.out.println("Game Type : "+this.GameType);
			System.out.println("Price($) : "+this.GamePrice);
		}
		
		public String getGameInfoAsString(){
		
		
		return 
		        "Code : "+GameCode+"\n"+
				"Name : "+GameName+"\n"+
				"Genre : "+GameGenre+"\n"+
				"Type : "+GameType+"\n"+
				"Price($) : "+GamePrice+"\n";
				
	}
	
	
}