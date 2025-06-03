public class CWH_34_PSonMethods {
    
    static void multiplication(int n){
        for(int i=1;i<=10;i++){
            System.out.format("%d X %d = %d\n", n, i , n*1);
        }
    }
    static void pattern1(int n){
        // pattern1_rec(3)
        // pattern1_rec(2) + 3 times star and new line
        // pattern1_rec(1) + 2 times star and new line + 3 times star and new line
        // pattern1_rec(0) + 1 times star and new line + 2 times star and new line + 3 times star and new line
        for(int i = 0; i <n; i++){
            for(int j = 0; j < i+1; j++){
                System.out.print("*");
        }
            System.out.println();
        }
    }
    static int sumRec(int n){
        // sum(n) = 1 + 2 + 3... + n
        // sum(n) = 1 + 2 + 3... + n-1 + n
        // sum(n) = sum(n-1) + n
        // sum(3) = 3 + sum(2)
        // sum(3) = 3 + 2 + sum(1)
        // sum(3) = 3 + 2 + 1
        if(n==1){
            return 1;
        }
        return  n + sumRec(n-1);
    }
    static void pattern2(int n){
        // pattern1_rec(3)
        // pattern1_rec(2) + 3 times star and new line
        // pattern1_rec(1) + 2 times star and new line + 3 times star and new line
        // pattern1_rec(0) + 1 times star and new line + 2 times star and new line + 3 times star and new line
        for(int i = n; i>0; i--){
            for(int j = 0; j < i; j++){
                System.out.print("*");
        }
            System.out.println();
        }
    }
    static int fib(int n){
        /*if(n==1){
            return 0;
        }else if(n==2){
            return 1;
        */
        if(n==1 || n==2){
            return n-1;
        }
        else{
            return fib(n-1) +fib(n-2);
        }
    }
    static void pattern1_rec(int n){
        
        if(n>0){
            pattern1_rec(n-1);
            for(int i = 0; i<n; i++){
                System.out.print("*");
        }
        System.out.println();
    }
    }

    public static void main(String[] args) {
        //p1
        //multiplication(7);
        
        //p2
        //pattern1(4);
        
        //p3
        //int  c = sumRec(3);
        //System.out.println(c);
        
        //p4
        //pattern2(4);

        //p5
        // fibonacchi series - 0,1,1,2,3,5,8,13,21,34....
        //int result = fib(5);
        //System.out.println(result);

        //p8
        pattern1_rec(1);
    }  
}


