import java.awt.Color;
import java.awt.Font;
import javax.swing.BorderFactory;
import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.border.Border;



public class Main{
    public static void main(String[] args) {
        // JLabel = GUI display area for Sting of test, an image, or both

        ImageIcon image = new ImageIcon("hacker2.jpg");

        Border border = BorderFactory.createLineBorder(Color.green,3);

        JLabel label = new JLabel(); // creat a label
        label.setText("Bro, Do you even code?"); // set text of label
        label.setIcon(image);
        label.setHorizontalTextPosition(JLabel.CENTER); // set text LEFT, CENTER, RIGHT of imageicon
        label.setVerticalTextPosition(JLabel.TOP); // set text TOP, CENTER, BOTTOM of imageicon
        label.setForeground(new Color(27, 142, 198)); // set font color
        label.setFont(new Font("Century Gothic", Font.PLAIN,50)); // set font of text
        label.setIconTextGap(-25); //set gap of text to image
        label.setBackground(Color.black); // set Bg color
        label.setOpaque(true); // display background color
        label.setBorder(border);
        label.setVerticalAlignment(JLabel.CENTER); // set vertical pos of icon+text within label
        label.setHorizontalAlignment(JLabel.CENTER); // set horizontal pos of icon+text within label
        label.setBounds(100,100,250,250); // X,Y and dimention

        JFrame frame = new JFrame();
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        //frame.setSize(500,500);
        //frame.setLayout(null);
        frame.setVisible(true);
        frame.add(label);
        frame.pack();

    }
}