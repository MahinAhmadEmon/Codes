import javax.swing.JFrame;
import javax.swing.ImageIcon;
import java.awt.Color;

public class MyFrame extends JFrame{
    
    MyFrame(){
        this.setTitle("JFrame title goes here");
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setResizable(false); //prevent resize
        this.setSize(420,420); // X,Y of the frame
        this.setVisible(true); //make frame visible

        ImageIcon image = new ImageIcon("hacker.jpg"); // create and image icon
        this.setIconImage(image.getImage()); // change icon of frame
        this.getContentPane().setBackground(new Color(123,50,250)); //chnge color of bg

    }
}
