package File;
import Entity.*;
import EntityList.*;
import java.io.*;
import java.util.*;

public class UFileIO{
	public static boolean checkUserFromFile(String userName,String userPass){
		try{
			Scanner sc = new Scanner(new File("./File/user.txt"));
			while(sc.hasNextLine()){
				String data[] = sc.nextLine().split(";");
				if(data[0].equals(userName) && data[1].equals(userPass)){
					sc.close();
					return true;
				}				
			}
			sc.close();
		}
		catch(Exception e){
			
		}
		return false;
	}
	public static void writeUserInFile(String userName, String userPass) {
    try {
        FileWriter writer = new FileWriter(new File("./File/user.txt"), true);
        String data = userName + ";" + userPass + "\n";
        writer.write(data);
        writer.close();
    } catch (Exception e) {
        
    }
}

		
}