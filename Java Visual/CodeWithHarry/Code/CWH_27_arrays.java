public class CWH_27_arrays {
    public static void main(String[] args) {
        int [] marks = {98, 45, 76, 89, 61};
        System.out.println(marks.length);
        String [] students = {"Harry", "Mahin", "Tumpa" , "Ela"};
        // (Naive way)
        System.out.println("print with naive way");
        System.out.println(students.length);
        System.out.println(students[0]);
        System.out.println(students[1]);
        System.out.println(students[2]);
        System.out.println(students[3]);
        
        //(for loop)
        System.out.println("print with for loop");
        for(int i = 0; i<students.length; i++){
            System.out.println(students[i]);
        }
        // reverse
        System.out.println("print with reverse loop");
        for(int i = students.length -1; i>= 0;i--){
            System.out.println(students[i]);
        }
        System.out.println("print with Elements");
        for(String element: students){
            System.out.println(element);
        }


    }
}
