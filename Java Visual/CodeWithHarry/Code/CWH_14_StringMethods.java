public class CWH_14_StringMethods {
    public static void main(String[] args) {
        String name = "Mahin";
        System.out.println(name);
        
        int value = name.length();
        System.out.println(value);
        
        String lstring = name.toLowerCase();
        System.out.println(lstring);

        String ustring = name.toUpperCase();
        System.out.println(ustring);

        String nonTimmedString = "     Mahin    ";
        System.out.println(nonTimmedString);
        String trimmedString;
        System.out.println(nonTimmedString.trim());

        System.out.println(name.substring(2,5));

        System.out.println(name.replace('M', 'B'));
        System.out.println(name.replace("Mah", "Sah"));
        
        System.out.println(name.startsWith("Mah"));
        System.out.println(name.startsWith("Hah"));

        System.out.println(name.endsWith("in"));
        System.out.println(name.endsWith("hn"));

        System.out.println(name.charAt(1));

        System.out.println(name.indexOf("h",1));

        System.out.println(name.lastIndexOf("n"));
        

        System.out.println(name.equals("Mahin"));
        System.out.println(name.equals("mahin"));
        System.out.println(name.equalsIgnoreCase("mahin"));

    }
}
