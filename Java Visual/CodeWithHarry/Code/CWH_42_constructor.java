class MyMainEmployee{
    private int id;
    private String name;

    // public MyMainEmployee(){
    //     id = 45;
    //     name = "Your-Name-Here";
    // }
    public MyMainEmployee(String myName, int myId){
        id = myId;
        name = myName;
    }
    public void setName(String n) { this.name = n;}
    public String getName() { return name; }
    public void setId(int i) { this.id = i; }
    public int getId() { return id; }
}

public class CWH_42_constructor {
    public static void main(String[] args) {
        MyMainEmployee harry = new MyMainEmployee("PWithHarry", 24);
        // harry.setName("CodeWtihHarry");
        // harry.setId(34);
        System.out.println(harry.getName());
        System.out.println(harry.getId());
    }
}
