public class CWH_24_breakncontinue {
    public static void main(String[] args) {
        //Break and continue using loops!
        // for(int i = 0; i < 5; i++){
        //     System.out.println(i);
        //     System.out.println("Java is FUN!");
        //     if(i==2){
        //         System.out.println("Ending the loop");
        //         break;
        //     }
        // }
        for(int i = 0; i < 5; i++){
                if(i==2){
                    System.out.println("Ending the loop");
                    continue;
                }
                System.out.println(i);
                System.out.println("Java is FUN!");
            }
               
        // int i = 0;
        // do{
        //     System.out.println(i);
        //     System.out.println("Java is FUN!");
        //     if(i==2){
        //         System.out.println("Ending the loop");
        //         break;
        //     }
        //     i++;
        // }while(i<5);
        // System.out.println("loop ends here");
    }
}
