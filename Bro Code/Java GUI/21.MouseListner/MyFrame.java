import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.event.*;
import javax.swing.*;



public class MyFrame extends JFrame implements MouseListener{

    JLabel label;
    ImageIcon laugh;
    ImageIcon laughing;
    ImageIcon normal;

    MyFrame(){
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setSize(500,500);
        this.setLayout(new FlowLayout());

        laugh = new ImageIcon("laugh.png");
        laughing = new ImageIcon("laughing.png");
        normal = new ImageIcon("normal.png");


        label = new JLabel();
        label.addMouseListener(this);
        label.setIcon(normal);



        this.add(label);
        this.pack();
        this.setLocationRelativeTo(null);
        this.setVisible(true);
    }

    @Override
    public void mouseClicked(MouseEvent e){
        label.setIcon(laugh);
    }

    @Override
    public void mousePressed(MouseEvent e){
        label.setIcon(laughing);

    }

    @Override
    public void mouseReleased(MouseEvent e) {
        System.out.println("You Released the Mouse");
        label.setIcon(laughing);
    }

    @Override
    public void mouseEntered(MouseEvent e) {
        label.setIcon(normal);
    }

    @Override
    public void mouseExited(MouseEvent e) {
        label.setIcon(normal);
    }
}
