import java.util.Scanner;
public class CWH_18_elseif {
    public static void main(String[] args) {
        int age;
        System.out.println("Enter your age: ");
        Scanner sc = new Scanner(System.in);
        age = sc.nextInt();

        switch (age) {
            case 18 -> System.out.println("You r going to become an Adult");
                
            case 23 -> System.out.println("u r going to join a job");
                
            case 60 -> System.out.println("u r gonna retire");
                
            default ->System.out.println("Enjoy ur life");
        }

        /*
        if(age > 56){
            System.out.println("You r experienced");
        }else if(age > 46){
            System.out.println("You r semi experienced");
        }else if(age > 36){
            System.out.println("You r semi semi experienced");
        }else{
            System.out.println("you r not experienced");  
        }
        */
    }
}
