import java.awt.color.*;
import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.font.*;
import java.awt.event.*;
import javax.swing.*;



public class MyFrame extends JFrame implements ActionListener{

    JButton button;
    JLabel label;

    MyFrame(){
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setLayout(new FlowLayout());

        button = new JButton("Pick a Color");
        button.addActionListener(this);
        
        label = new JLabel();
        label.setBackground(Color.WHITE);
        label.setOpaque(true);
        label.setText("I love you TUMPA");
        label.setFont(new Font("Arial", Font.PLAIN,100));

        this.add(button);
        this.add(label);
        this.pack();
        this.setVisible(true);
    }


    @Override
    public void actionPerformed(ActionEvent e){
        if(e.getSource()==button){
            JColorChooser colorChooser = new JColorChooser();

            Color color = JColorChooser.showDialog(null, "Pick a color", Color.BLACK);
            
            //label.setForeground(color);
            label.setBackground(color);
        }
    }
    
}
