import java.util.Scanner;
public class CWH_06_PS1 {
    public static void main(String[] args) {
        /*  Q 
        {Write a program to calculate percentage of a given
        student in HSC board exam. His marks from 5 subjects
        must be taken as input  from the keybaord.
        (marks are out of 100)}
        */
        System.out.println("Marks for the Subjects");
        Scanner num = new Scanner (System.in);
        System.out.println("Bangla: ");
        double num1 = num.nextDouble();
        System.out.print("Sub1 Bangla: ");
        System.out.println(num1);
        System.out.println("English: ");
        double num2 = num.nextDouble();
        System.out.print("Sub2 English: ");
        System.out.println(num2);
        System.out.println("Math: ");
        double num3 = num.nextDouble();
        System.out.print("Sub3 Math: ");
        System.out.println(num3);
        System.out.println("Science: ");
        double num4 = num.nextDouble();
        System.out.print("Sub4 Science: ");
        System.out.println(num4);
        System.out.println("Social Science: ");
        double num5 = num.nextDouble();
        System.out.print("Sub5 Social Science: ");
        System.out.println(num5);

        double sum = ((num1 + num2 + num3 + num4 + num5)/5);
        System.out.print("Average of the 5 subjects: ");
        System.out.println(sum);
    }
}
