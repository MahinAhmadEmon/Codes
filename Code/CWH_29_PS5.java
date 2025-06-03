public class CWH_29_PS5 {
    public static void main(String[] args) {
        /*   Q1
        Creat an array of 5 floats and calculate their sun
        */
        // float [] marks = {12.5f , 45.5f , 99.5f, 23.5f, 14.5f};
        // float sum = 0;
        // for(float elements:marks){
        //     sum = sum + elements;
        // }
        // System.out.println("The value of sum is " + sum);

        /*  Q2
        Write a program to fidn out weather a given interger is
        present in an array or not?
        */
        // float [] marks = {12.5f , 45.5f , 99.5f, 23.5f, 14.5f};
        // float num = 12.5f;
        // boolean isInArray = false;
        // for(float elements:marks){
        //     if(num == elements){
        //         isInArray = true;
        //         break;
        //     }
        // }
        // if(isInArray){
        //     System.out.println("The value is present");
        // }else{
        //     System.out.println("The value is not here");
        // }

        /*  Q3
        Calculate the average marks from an array containing marks
        of all students in Physics using for each loop
        */
        // float [] marks = {12.5f , 45.5f , 99.5f, 23.5f, 14.5f};
        // float sum = 0;
        // for(float elements:marks){
        //     sum = sum + elements;
        // }
        // System.out.println("The value of average marks is " + sum/marks.length);

        /* Q4
        Create a Java programe to add two matrix of size 2X3  
        */
        // int [][] mat1 = {{1,2,3},
        //                 {4,5,6}};
        // int [][] mat2 = {{7,8,9},
        //                 {1,3,5}};
        // int [][] result = {{0,0,0},
        //                  {0,0,0}};  
        // for (int i = 0; i < mat1.length; i++) { //row number of times
        //     for (int j = 0; j<mat1[i].length; j++){ // coloumn number of times 
        //         System.out.format(" Setting value for i=%d and j=%d\n", i , j);
        //         result[i][j] = mat1[i][j] + mat2[i][j];
        //     }
        // }
        // for (int i = 0; i < mat1.length; i++) { //row number of times
        //     for (int j = 0; j<mat1[i].length; j++){ // coloumn number of times 
        //         System.out.print(result[i][j]  + " ");
        //     }
        //     System.out.println("");
        // }  
        
        /* Q5
        Write a Java program to reverse a array  
        */
        // int [] arr = {1,2,3,4,5,6};
        // int l = arr.length;
        // int n = Math.floorDiv(arr.length, 2);
        // int temp;

        // for(int i=0; i<n; i++){
        //     //swap a[i] and a[l-l1-i]
        //     // a b temp
        //     // |4| |3| | |
        //     temp = arr[i];
        //     arr[i] = arr[l-i-1];
        //     arr[l-i-1] = temp;
        // }
        // for(int element: arr){
        //     System.out.println(element+ " ");
        // }

        /*
        Q5
        Write a java programe to find the maximum element in an array
        */
        // int []arr = {1, 21, 240, 56, 78, 99};
        // int max = 0;
        // for (int e: arr){
        //     if(e>max){
        //         max = e;
        //     }
        // }
        // System.out.println("The max element is: "+ max);

        /*
        Q6
        Write a java programe to find the maximum element in an array
        */
        // int[] arr = {10, 21, 240, 56, 78, 99};
        // int min = arr[0]; 
        // for (int e : arr) {
        // if (e < min) {
        // min = e;
        //     }
        // }
        // System.out.println("The minimum element is: " + min);

        /*
        Q7
        Write a java programe to find weather an array is sorted or not
        */
        boolean isSorted = true;
        int[] arr = {1, 2, 3, 4, 5, 6};
        for(int i = 0; i<arr.length-1; i++){
           if( arr[i] > arr[i+1]){
            isSorted = false;
            break;
           }
        }
        if(isSorted){
            System.out.println("Is sorted");
        }else{
            System.out.println("Not sorted");
        }


        
        

        
        

        



        
    }
}
