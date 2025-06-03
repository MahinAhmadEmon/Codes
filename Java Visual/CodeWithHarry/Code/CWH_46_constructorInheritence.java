class Base1{
    Base1(){
        System.out.println("I am a constructor");
    }
    Base1(int a){
        System.out.println("I am an overloaded constructor with a value of as: "+a);
    }
    public int x;

    public int getX(){
        return x;
    }

    public void setX(int  x){
        this.x = x;
    }
}

class Derived1 extends Base1{
    Derived1(){
        //super(0);
        System.out.println("I am a Derived class constructor");
    }
    Derived1(int a, int b){
        super(a);
        System.out.println("I am an overloaded Derived class constructor of Derived with value of b as: "+ b);
    }
    public int y;

    public int getY(){
        return y;
    }

    public void setY(int  y){
        this.y = y;
    }
}

class ChildOfDerived extends Derived1{
    ChildOfDerived(){
        System.out.println("I am a Child of Derived Constructor");
    }
    ChildOfDerived(int a, int b, int c){
        super(a, b);
        System.out.println("I am an overloaded Derived class constructor of Derived with value of b as: "+ c);
    }
}


public class CWH_46_constructorInheritence{
    public static void main(String[] args) {
        //Base1 b = new Base1();
        //Derived1 d = new Derived1();
        //Derived1 d = new Derived1(4, 9);
        ChildOfDerived cd = new ChildOfDerived(1, 2, 3);

    }
}