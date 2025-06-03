import java.util.Scanner;
import java.util.Random;

public class CWH_20_RPS {
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        Random random = new Random();
        
        int userChoice;
        int computerChoice;
        String userMove;
        String computerMove;

        System.out.println("Welcome to Rock Paper Scissors!");

        while (true) {
        System.out.println("Choose your move:");
        System.out.println("1 - Rock");
        System.out.println("2 - Paper");
        System.out.println("3 - Scissors");

        userChoice = scanner.nextInt();

        if (userChoice < 1 || userChoice > 3){
            System.out.println("invalid try again");
            continue;
        }
        computerChoice = random.nextInt(3) + 1;

        userMove = getMoveName(userChoice);
        computerMove = getMoveName(computerChoice);

        System.out.println("You chose : " + userMove);
        System.out.println("Computer chose: " + computerMove);

        if(userChoice == computerChoice){
            System.out.println("It's a TIE!");
        }else if((userChoice == 1 && computerChoice == 3) || 
        (userChoice == 2 && computerChoice == 1) || (userChoice == 3 && computerChoice == 2)){
            System.out.println("You WIN!");
        }else{
            System.out.println("You LOSE!");
        }
        System.out.println("Play again? (y/n)");
        String playAgain = scanner.next();
        if(!playAgain.equalsIgnoreCase("y")){
            break;
        }
        }
        System.out.println("Thanks for playing!");
    }
    private static String getMoveName(int move){
        switch (move){
            case 1:
            return "rock";
            case 2:
            return "paper";
            case 3:
            return "scissors";
            default:
            return "Invalid";
        }
    }
}
