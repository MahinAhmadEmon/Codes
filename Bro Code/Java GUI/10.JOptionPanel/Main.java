import javax.swing.ImageIcon;
import javax.swing.JOptionPane;

public class Main{
    public static void main(String[] args) {
        //JOptionPane = pop up a standard dialog box that prompts users
        //              for a value or imforms time of something.
        
        // JOptionPane.showMessageDialog(null, "This is some useless info", "Title", JOptionPane.PLAIN_MESSAGE);
        // JOptionPane.showMessageDialog(null, "This is some useless info", "Title", JOptionPane.INFORMATION_MESSAGE);
        // JOptionPane.showMessageDialog(null, "This is some useless info", "Title", JOptionPane.QUESTION_MESSAGE);
        // JOptionPane.showMessageDialog(null, "This is some useless info", "Title", JOptionPane.WARNING_MESSAGE);
        // JOptionPane.showMessageDialog(null, "This is some useless info", "Title", JOptionPane.ERROR_MESSAGE);

        //System.out.println(JOptionPane.showConfirmDialog(null, "Do you even code", "This is my title", JOptionPane.YES_NO_CANCEL_OPTION));
        //int answer =  JOptionPane.showConfirmDialog(null, "Do you even code", "This is my title", JOptionPane.YES_NO_CANCEL_OPTION);
        
        //String name = JOptionPane.showInputDialog("What is ur name");
        //System.out.println("Hello " + name);


        String[] responses = {"No, you are good","Thanks","Blush"};
        ImageIcon icon = new ImageIcon("smile.png");
        JOptionPane.showOptionDialog(null, 
        "You are good", 
        "Secret", 
        JOptionPane.YES_NO_CANCEL_OPTION, 
        JOptionPane.INFORMATION_MESSAGE, 
        icon, 
        responses, 
        0);

    
    }

}