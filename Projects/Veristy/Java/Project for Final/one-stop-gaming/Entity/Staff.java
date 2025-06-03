package Entity;
public class Staff {
    private String name;
	private String id;
	private String age;
    private int salary;
	

public Staff(){};

public Staff(String name,String id,String age,int salary){
	this.name=name;
	this.id=id;
	this.age=age;
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
    public void setSalary(int salary)
    {
        this.salary=salary;
    }
	


    public String getName(){return this.name;}
	public String getId(){return this.id;}
    public String getAge(){return this.age;}
    public int getSalary(){return this.salary;}
	
	
	
	public void showStaffInfo(){
		System.out.println("\nName : "+name);
		System.out.println("ID : "+id);
		System.out.println("Age : "+age);
		System.out.println("Salary(Taka) : "+salary);
	}
	
	
    public String getStaffInfoAsString(){
		
		
		return 
		        "Staff Name : "+name+"\n"+
				"Staff ID : "+id+"\n"+
				"Staff Age : "+age+"\n"+
				"Salary(Taka) : "+salary+"\n";
	}
	
}
