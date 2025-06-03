public class CWH_32_method_overloading {
    static void foo(){
        System.out.println("Good monring bro");
    }
    static void foo(int a){
        System.out.println("Good monring bro " + a +" Bro");
    }
    static void foo(int a, int b){
        System.out.println("Good monring bro " + a + " Bro");
        System.out.println("Good morning bro " + b + " Bros");
    }
    static void foo(int a, int b, int c){
        System.out.println("Good monring bro " + a + " Bro");
        System.out.println("Good morning bro " + b + " Bros");
        System.out.println("Good morning bro " + c + " Bros");
    }

    static void change(int a){
        a = 98;
    }
    static void change2(int [] arr){
        arr[0] = 98;
    }
    static void tellJoke()
        {System.out.println("I invented a new word!\n" + 
                            "Plagiarism");
    }
    public static void main(String[] args) {
        // tellJoke();
        
        // Case 1: Changing the int
        // int x = 45;
        // change(x);
        // System.out.println("The value of X after running change is: "+ x);
        
        //Case 2: Changing the array
        // int [] marks = {12, 25, 15, 14, 13, 23};
        // change2(marks);
        // System.out.println("The value of X after running change is: "+ marks[0]);

        //Method Overlaoding 
        foo();
        foo(300);
        foo(350, 400); 
        foo(450, 500, 550); 
        //Arguments are actual!

        
    }
}
