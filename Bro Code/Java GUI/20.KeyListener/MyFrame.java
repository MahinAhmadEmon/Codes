import java.awt.Color;
import java.awt.event.*;
import javax.swing.*;



public class MyFrame extends JFrame implements KeyListener{
    
    JLabel label;
    MyFrame(){
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setSize(500,500);
        this.setLayout(null);
        this.addKeyListener(this);

        label = new JLabel();
        label.setBounds(0,0,100,100);
        label.setBackground(Color.red);
        label.setOpaque(true);

        this.setVisible(true);
        this.add(label);


    }

    

    @Override
    public void keyTyped(KeyEvent e){
        //keyTyped = Invoked when a key is typed. Uses KeyChar, char output
        switch(e.getKeyChar()){
            case 'a': label.setLocation(label.getX()-5 ,label.getY());
            break;
            case 'w': label.setLocation(label.getX() ,label.getY()-5);
            break;
            case 's': label.setLocation(label.getX() ,label.getY()+5);
            break;
            case 'd': label.setLocation(label.getX()+5 ,label.getY());
            break;
        }
    }

    @Override
    public void keyPressed(KeyEvent e){
        //keyPressesd = Invoked when a physical key is pressed down. Uses KeyCode, int output
        switch(e.getKeyCode()){
            case 37: label.setLocation(label.getX()-10 ,label.getY());
            break;
            case 38: label.setLocation(label.getX() ,label.getY()-10);
            break;
            case 39: label.setLocation(label.getX()+10 ,label.getY());
            break;
            case 40: label.setLocation(label.getX() ,label.getY()+10);
            break;
    }
    }
    @Override
    public void keyReleased(KeyEvent e){
        //keyPeleased = called whenever a button is released
        System.out.println("You released key Char: "+ e.getKeyChar());
        System.out.println("You released key Code: "+ e.getKeyCode());
    }
}
