
class Base{
    int x;

    public void setX(int x){
        System.out.println("I am in base and setting x now");
        this.x = x;
    }

    public int getX(){
        return x;
    }
    Base(){
        System.out.println("I am a construsctor");
    }

}

class Derived extends Base{
    int y;
    
    public void setY(int y){
        this.y = y;
    }
    public int getY(){
        return y;
    }

}



public class CWH_45_Inheritence {
    public static void main(String[] args){
        // Creating an object of Base class
        Base b = new Base();
        b.setX(4);
        System.out.println(b.getX());

        // Creating an object of derived class
        Derived d = new Derived();
        d.setX(43);
        System.out.println(d.getX());

    }
}
