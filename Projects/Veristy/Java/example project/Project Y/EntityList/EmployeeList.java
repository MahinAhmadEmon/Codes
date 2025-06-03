package EntityList;
import Entity.Employee;

public class EmployeeList {
    private Employee employees[];

    public EmployeeList() {
        employees = new Employee[5];
    }

    public EmployeeList(int size) {
        employees = new Employee[size];
    }

    public void insert(Employee e) {
        boolean flag = false;
        for (int i = 0; i < employees.length; i++) {
            if (employees[i] == null) {
                employees[i] = e;
                flag = true;
                break;
            }
        }
        if (flag) {
            System.out.println("Employee Inserted"); } 
			else {
            System.out.println("Failed to Insert Employee");
        }
    }

    public Employee getById(String id) {
        for (int i = 0; i < employees.length; i++) {
            if (employees[i] != null) {
                if (employees[i].getId().equals(id)) {
                    return employees[i];
                }
            }
        }
        return null;
    }

    public void deleteById(String id) {
        boolean flag = false;
        for (int i = 0; i < employees.length; i++) {
            if (employees[i] != null) {
                if (employees[i].getId().equals(id)) {
                    employees[i] = null;
                    flag = true;
                    break;
                }
            }
        }
        if (flag) {
            System.out.println("Employee Deleted");
        } else {
            System.out.println("Failed to Delete Employee");
        }
    }

    public void searchByName(String name) {
        for (int i = 0; i < employees.length; i++) {
            if (employees[i] != null) {
                if (employees[i].getName().equals(name)) {
                    System.out.println("Employee Found");
                    employees[i].showEmployeeInfo();
                    return;
                }
            }
        }
        System.out.println("-- Employee Not Found ---");
		return;
    }

    public void showAll() {
        System.out.println("-------------List of All Employees-----------");
        for (int i = 0; i < employees.length; i++) {
            if (employees[i] != null) {
                System.out.println("---------------------");
                employees[i].showEmployeeInfo();
            }
        }
        System.out.println("---------------------");
    }
		public String getAll(){
		String allEmployee = "";
		for(int i=0;i<employees.length;i++){
			if(employees[i] != null){ 
			
				allEmployee += "-----------------  "+  employees[i].getId() +"  ---------------\n";
				allEmployee += employees[i].getEmployeeInfoAsString();
			}
			
		}
		
			allEmployee += "----------------------------------------\n";
		return allEmployee;}
	
	public Employee[] getAllEmployee(){
		return employees;
		
		}
	
	
}