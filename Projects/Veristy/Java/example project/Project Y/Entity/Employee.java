package Entity;
public class Employee {
    private String name;
	private String id;
	private String age;
    private String shift;
    private int salary;
	

public Employee(){};

public Employee(String name,String id,String age,String shift,int salary){
	this.name=name;
	this.id=id;
	this.age=age;
	this.shift=shift;
	this.salary=salary;
};



    public void setName(String name)
    {
        this.name=name;
    }
	 public void setId(String id)
    {
        this.id=id;
    }
    public void setAge(String age)
    {
        this.age=age;
    }
	 public void setShift(String shift)
    {
        this.shift=shift;
    }
    public void setSalary(int salary)
    {
        this.salary=salary;
    }
	


    public String getName(){return this.name;}
	public String getId(){return this.id;}
    public String getAge(){return this.age;}
	public String getShift(){return this.shift;}
    public int getSalary(){return this.salary;}
	
	
	
	public void showEmployeeInfo(){
		System.out.println("\nName : "+name);
		System.out.println("ID : "+id);
		System.out.println("Age : "+age);
		System.out.println("Shift : "+shift);
		System.out.println("Salary : "+salary);
	}
	
	
	
    public String getEmployeeInfoAsString(){
		
		
		return 
		        "Employee Name : "+name+"\n"+
				"Employee ID : "+id+"\n"+
				"Employee Age : "+age+"\n"+
				"Employee Shift : "+shift+"\n"+
				"Salary : "+salary+"\n";
	}
	
	
}
