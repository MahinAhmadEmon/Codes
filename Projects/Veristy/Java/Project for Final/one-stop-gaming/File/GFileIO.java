package File;
import java.io.*;
import java.util.Scanner;
import Entity.*;
import EntityList.*;
public class GFileIO{
	public static void loadGamesFromFile(GameMenu GameMenu){
		try{
			Scanner sc = new Scanner(new File("./File/games.txt"));
			while(sc.hasNextLine()){
				String data[] = sc.nextLine().split(";");
				Game f = new Game(data[0],data[1],data[2],data[3],Integer.parseInt(data[4]));
				GameMenu.insert(f);
			}
			sc.close();
		}
		catch(Exception e){
			
		}
	}
	
	public static void writeGameInFile(Game f){
		try{
			FileWriter writer = new FileWriter(new File("./File/games.txt"),true);
			String data = f.getGameCode()+";"+f.getGameName()+";"+
						  f.getGameGenre()+";"+f.getGameType()+";"+
						  f.getGamePrice()+"\n";
			writer.write(data);
			writer.close();
		}
		catch(Exception e){
			
		}
	}
	
	public static void updateGamesInFile(GameMenu GameMenu){
		try{
			FileWriter writer = new FileWriter(new File("./File/games.txt"));
			Game Games[] = GameMenu.getAllGames();
			
			String allData="";
			
			for(int i=0;i<Games.length;i++){
				if(Games[i]!=null){
					String data = Games[i].getGameCode()+";"+Games[i].getGameName()+";"+
						  Games[i].getGameGenre()+";"+Games[i].getGameType()+";"+
						  Games[i].getGamePrice()+"\n";
					
					allData+=data;
				}
			}
			writer.write(allData);
			writer.close();
		}
		catch(Exception e){
			
		}
	}

	
	public static void saveGamesInFile(GameMenu GameMenu){
		try {
		FileWriter writer = new FileWriter(new File("./File/games.txt"));
			Game Games[] = GameMenu.getAllGames();
			
			String allData="";
			for(int i=0;i<Games.length;i++){
				if(Games[i]!=null){
					String data = Games[i].getGameCode()+";"+Games[i].getGameName()+";"+
						  Games[i].getGameGenre()+";"+Games[i].getGameType()+";"+
						  Games[i].getGamePrice()+"\n";
					
					allData+=data;
				}
			}
			writer.write(allData);
			writer.close();
		} catch (IOException e) {
			System.out.println("Cannot Write in File");
		}
	}
}