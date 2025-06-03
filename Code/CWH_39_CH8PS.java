import javax.swing.CellEditor;

class Employee{
    int salary;
    String name;

    public int getSalary(){
        return salary;
    }
    public void setName(String n){
        name = n;
    }
    public String getName(){
        return name;
    }
}

class CellPhone{
    public void ring(){
        System.out.println("Ringing....");
    }
    public void vibrat(){
        System.out.println("Vibrating...");
    }
    public void callFriend(){
        System.out.println("Calling Tumpa...");
    }
}

class Square{
    int side;
    public int area(){
        return side*side;
    }
    public int perimeter(){
        return 4*side;
    }
}

class Rectangular{
    int length;
    int width;
    public int area(){
        return length*width;
    }
    public int perimeter(){
        return 2*(length+width);
    }
}

class Tommy{
    public void hit(){
        System.out.println("Hitting the Enemy");
    }
    public void run(){
        System.out.println("running the Enemy");
    }
    public void fire(){
        System.out.println("Fireing the Enemy");
    }
}

public class CWH_39_CH8PS {
    public static void main(String[] args) {

        // //P1
        // Employee mahin = new Employee();
        // mahin.setName("Mahin Ahmad Emon");
        // mahin.salary = 3000;
        // System.out.println(mahin.getName());
        // System.out.println(mahin.getSalary());

        // //P2
        // CellPhone poco = new CellPhone();
        // poco.callFriend();
        // poco.vibrat();
        // poco.ring();

        // //P3
        // Square sq = new Square();
        // sq.side = 3;
        // System.out.println(sq.area());
        // System.out.println(sq.perimeter());

        // //P4
        // Rectangular sq = new Rectangular();
        // sq.length = 3;
        // sq.width = 4;
        // System.out.println(sq.area());
        // System.out.println(sq.perimeter());

        // //P5
        // Tommy player1 = new Tommy();
        // player1.hit();
        // player1.run();
        // player1.fire();

        

        




    }
}
