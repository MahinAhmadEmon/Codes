import java.util.Scanner;

public class CWH_19_PS4 {
    public static void main(String[] args) {
    /* Q1
    What will be the putput of this programe:
    */
    // int a = 10;
    // if(a == 11){
    // System.out.println("I am eleven");
    // }else{
    // System.out.println("I am not eleven");
    // }


    /* Q2
    Write a programe to find out weather a student is pass or fail: if it
    requires total 40% and at least 33% in each subject to pass. assume 3
    subjects and take marks as an input from the user.
    */
    //    Scanner sc = new Scanner(System.in);
    //    System.out.println("Enter for English: ");
    //    float num1 = sc.nextFloat();
    //    
    //    System.out.println("Enter for Bangla: ");
    //    float num2 = sc.nextFloat();
    //    
    //    System.out.println("Enter for Math: ");
    //    float num3 = sc.nextFloat();
    //    
    //    float sum = (num1+num2+num3)/3.0f;
    //    System.out.println("Your average number is " + sum);
    //    if(sum>=40 && num1>=33 && num2>=33 && num3>= 33){
    //        System.out.println("You have PASSED!");
    //    }else{
    //       System.out.println("You have FAILED!");
    //    }


    /* Q3
    Calculate income tax paid by an employee to the 
    government as per the slots mentioned below
        income slot     tax
        2.5L - 5.0L     5%
        5.0L - 10.0L    20%
        above 10.0L     30%
    note that there is no tax below 2.5L. take imput
    amount as an input from the user
    */
    // Scanner sc = new Scanner(System.in);
    // System.out.println("Enter Your Income: ");
    // float tax = 0;
    // float income = sc.nextFloat();
    // if(income<=2.5f){
    //     tax  = tax + 0;
    // }
    // else if(income>2.5f && income<=5f){
    //     tax = tax + 0.05f * (income - 2.5f);
    // }
    // else if(income>5f && income <= 10f){
    //     tax = tax + 0.05f * (5.0f - 2.5f);
    //     tax = tax + 0.2f * (income - 2.5f);
    // }
    // else if(income>10f){
    //     tax = tax + 0.05f * (5.0f - 2.5f);
    //     tax = tax + 0.2f * (10.0f - 5f);
    //     tax = tax + 0.5f * (income - 2.5f);
    // }
    // System.out.println("Total tax paid: " + tax);


    /* Q4
    Write a Java programe to find out the day
    of the week given the number [1 for moday 2 for 
    tueday... and so on]
    */
    // Scanner sc = new Scanner(System.in);
    // int day = sc.nextInt();
    // switch (day) {
    //     case 1 -> System.out.println("Monday");
    //     case 2 -> System.out.println("Tuesday");
    //     case 3 -> System.out.println("Wednesday");
    //     case 4 -> System.out.println("Thursday");
    //     case 5 -> System.out.println("Friday");
    //     case 6 -> System.out.println("Saturday");
    //     case 7 -> System.out.println("Sunday");  
    // }


    /*Q5
    Write a Java programe to find weather a year entered
    by the user isa  leap year or not
    */
    // Scanner sc = new Scanner(System.in);
    // System.out.println("Enter a year: ");
    // int a = sc.nextInt();
    // if(a % 4  == 0 || a % 100 == 0){
    //     System.out.println("the year " + a + " is a Leap Year");
    // }else{
    //     System.out.println("The year " + a + " is not a Lap Year");
    // }


    /*Q6
    Write a programe to find out the tyep of website from
    the url
    .com -> commertial website
    .org -> organization website
    .edu -> educational website
    */
    // Scanner sc = new Scanner(System.in);
    // String name = sc.nextLine();
    // if(name.endsWith(".com")){
    //     System.out.println("It is Commertial Website");
    // }else if(name.endsWith(".org")){
    //     System.out.println("It is Organigation website");
    // }else if(name.endsWith(".in")){
    //     System.out.println("It is Indian Website");
    // }else{
    //     System.out.println("This is not a website");
    // }
    }
}