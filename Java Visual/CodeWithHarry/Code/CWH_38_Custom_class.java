class Employee1{
    int id;
    int salary;
    String name;
    public void printDetails(){
        System.out.println("My Id is "+id);
        System.out.println("My name is "+name);
    }

    public int getSalary(){
        return salary;
    }
}
public class CWH_38_Custom_class {
    public static void main(String[] args) {
        System.out.println("This is our custom class");
        Employee1 harry = new Employee1(); // Instantiating a new Employee Object
        Employee1 john = new Employee1();
        
        // Setting Attributes harry
        harry.id = 12;
        harry.name = "CodeWithHarry";
        harry.salary = 3400;

        // Setting Attributes john
        john.id = 13;
        john.name = "johnboy";
        john.salary = 2000;

        // Printing the Attributes
        // System.out.println(harry.id);
        // System.out.println(harry.name);
        harry.printDetails();
        john.printDetails();
        int salary = john.getSalary();
        System.out.println(salary);
    }
}
