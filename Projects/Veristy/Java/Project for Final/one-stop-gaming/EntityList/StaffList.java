package EntityList;
import Entity.Staff;

public class StaffList {
    private Staff Staffs[];

    public StaffList() {
        Staffs = new Staff[5];
    }

    public StaffList(int size) {
        Staffs = new Staff[size];
    }

    public void insert(Staff e) {
        boolean flag = false;
        for (int i = 0; i < Staffs.length; i++) {
            if (Staffs[i] == null) {
                Staffs[i] = e;
                flag = true;
                break;
            }
        }
        if (flag) {
            System.out.println("Staff Inserted"); } 
			else {
            System.out.println("Failed to Insert Staff");
        }
    }

    public Staff getById(String id) {
        for (int i = 0; i < Staffs.length; i++) {
            if (Staffs[i] != null) {
                if (Staffs[i].getId().equals(id)) {
                    return Staffs[i];
                }
            }
        }
        return null;
    }

    public void deleteById(String id) {
        boolean flag = false;
        for (int i = 0; i < Staffs.length; i++) {
            if (Staffs[i] != null) {
                if (Staffs[i].getId().equals(id)) {
                    Staffs[i] = null;
                    flag = true;
                    break;
                }
            }
        }
        if (flag) {
            System.out.println("Staff Deleted");
        } else {
            System.out.println("Failed to Delete Staff");
        }
    }

    public void searchByName(String name) {
        for (int i = 0; i < Staffs.length; i++) {
            if (Staffs[i] != null) {
                if (Staffs[i].getName().equals(name)) {
                    System.out.println("Staff Found");
                    Staffs[i].showStaffInfo();
                    return;
                }
            }
        }
        System.out.println("-- Staff Not Found ---");
		return;
    }

    public void showAll() {
        System.out.println("-------------List of All Staffs-----------");
        for (int i = 0; i < Staffs.length; i++) {
            if (Staffs[i] != null) {
                System.out.println("---------------------");
                Staffs[i].showStaffInfo();
            }
        }
        System.out.println("---------------------");
    }
		public String getAll(){
		String allStaff = "";
		for(int i=0;i<Staffs.length;i++){
			if(Staffs[i] != null){ 
			
				allStaff += "-----------------  "+  Staffs[i].getId() +"  ---------------\n";
				allStaff += Staffs[i].getStaffInfoAsString();
			}
			
		}
		
			allStaff += "----------------------------------------\n";
		return allStaff;}
	
	public Staff[] getAllStaff(){
		return Staffs;
		
		}
	
	
}