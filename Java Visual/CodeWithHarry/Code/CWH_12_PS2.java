import java.util.Scanner;
public class CWH_12_PS2 {
    public static void main(String[] args) {
        /*  Q1
        What will be the results of the follow expression?
        flaot a = 7/4 * 9/2
        */
        //float a = 7/4.0f * 9/2.0f;
        //System.out.println(a);

        /* Q2
        Write a java programe to encrypt a grade by
        adding 8 to it. decrypt it to show the correct grade
        */
        //char grade = 'B';
        //grade = (char)(grade + 8);
        //System.out.println(grade);

        // Decrypting the grade
        //grade = (char)(grade - 8);
        //System.out.println(grade);

        /*  Q3
        Use comparison opretors to find out
        whether a given number is greater then
        the user entered number or not.
        */
        //Sc sc = new Sc(System.in);
        //int a = sc.nextInt();
        //System.out.println(a>8);

        /* Q4
        Write the following expression in a java programe:
        v^2 - u^2/ 2as
        */
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter the value of v: ");
        double v = sc.nextDouble();
        System.out.print("Enter the value of u: ");
        double u = sc.nextDouble();
        System.out.print("Enter the value of a: ");
        double a = sc.nextDouble();
        System.out.print("Enter the value of s: ");
        double s = sc.nextDouble();
        double result = (Math.pow(v, 2) - Math.pow(u, 2)) / (2 * a * s);
        System.out.println("The value of the expression (v^2 - u^2)/2as is: " + result);
        
    }
}
