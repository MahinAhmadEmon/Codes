class EkClass {
  int a;

    EkClass(int v) {  // Constructor declaration
        this.a = v;
  }

  public int getA() {
    return a;
  }

  public int returnOne() {  // Method name should follow camelCase convention
    return 1;
  }
}

class DoClass extends EkClass{
    DoClass(int c){
        super(c);
        System.out.println("I am a constructor");
    }
}

public class CWH_47_thisAndSuper {
  public static void main(String[] args) {
    EkClass e = new EkClass(5);
    DoClass d = new DoClass(1);
    System.out.println(e.getA());
    
  }
}
