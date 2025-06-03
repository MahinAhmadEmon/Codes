package EntityList;
import Entity.*;
import Interfaces.*;
public class GameMenu implements IGameMenu{
    private Game Games[];

    public GameMenu() {
        Games = new Game[50];
    }

    public GameMenu(int size) {
        Games = new Game[size];
    }


    public void insert(Game f) {
        boolean flag = false;
        for (int i = 0; i < Games.length; i++) {
            if (Games[i] == null) {
                Games[i] = f;
                flag = true;
                break;
            }
        }
        if (flag) {
            System.out.println("Game Inserted");
        } else {
            System.out.println("Insertion Failed");
        }
    }


    public Game getByCode(String code) {
        for (int i = 0; i < Games.length; i++) {
            if (Games[i] != null) {
                if (Games[i].getGameCode().equals(code)) {
                    return Games[i];
                }
            }
        }
        return null;
    }

    public void deleteByCode(String code) {
        boolean flag = false;
        for (int i = 0; i < Games.length; i++) {
            if (Games[i] != null) {
                if (Games[i].getGameCode().equals(code)) {
                    Games[i] = null;
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
        for (int i = 0; i < Games.length; i++) {
            if (Games[i] != null) {
                if (Games[i].getGameName().equals(name)) {
                    System.out.println("Game Found");
                    Games[i].showGameInfo();
                    return;
                }
            }
        }
        System.out.println("-- Game Not Found ---");
    }

    public void showAll() {
        System.out.println("-------------Available Games-----------");
        for (int i = 0; i < Games.length; i++) {
            if (Games[i] != null) {
                System.out.println("---------------------");
                Games[i].showGameInfo();
            }
        }
        System.out.println("---------------------");
    }

	public String getAll(){
		String allGameInfo = "";
		for(int i=0;i<Games.length;i++){
			if(Games[i] != null){ 
			
				allGameInfo += "-----------------  \n";
				allGameInfo += Games[i].getGameInfoAsString();
			
			}
		}
		allGameInfo += "----------------------------------------\n";
		return allGameInfo;
	}
	
	
	public Game[] getAllGames(){return Games;}
	
}