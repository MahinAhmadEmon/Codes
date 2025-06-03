import java.awt.FlowLayout;
import java.awt.event.*;
import javax.swing.*;



public class MyFrame extends JFrame implements ActionListener{
    
    JMenuBar menuBar;
    JMenu filMenu;
    JMenu editMenu;
    JMenu helpMenu;
    JMenuItem loadItem;
    JMenuItem saveItem;
    JMenuItem exitItem;
    ImageIcon loadIcon;
    ImageIcon saveIcon;
    ImageIcon exitIcon;

    MyFrame(){
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setSize(500,500);
        this.setLayout(new FlowLayout());
        
        loadIcon = new ImageIcon("load.png");
        saveIcon = new ImageIcon("save.png");
        exitIcon = new ImageIcon("exit.png");

        menuBar = new JMenuBar();

        filMenu = new JMenu("File");
        editMenu = new JMenu("Edit");
        helpMenu = new JMenu("Help");
        
        loadItem = new JMenuItem("Load");
        saveItem = new JMenuItem("Save");
        exitItem = new JMenuItem("Exit");

        loadItem.addActionListener(this);
        saveItem.addActionListener(this);
        exitItem.addActionListener(this);

        loadItem.setIcon(loadIcon);
        saveItem.setIcon(saveIcon);
        exitItem.setIcon(exitIcon);


        filMenu.setMnemonic(KeyEvent.VK_F); //Alt + f for load
        editMenu.setMnemonic(KeyEvent.VK_E); //Alt + E for save
        helpMenu.setMnemonic(KeyEvent.VK_H); //Alt + H for exit
        loadItem.setMnemonic(KeyEvent.VK_L); //l for load
        saveItem.setMnemonic(KeyEvent.VK_S); //s for save
        exitItem.setMnemonic(KeyEvent.VK_E); //e for exit

        filMenu.add(loadItem);
        filMenu.add(saveItem);
        filMenu.add(exitItem);

        menuBar.add(filMenu);
        menuBar.add(editMenu);
        menuBar.add(helpMenu);
        this.setJMenuBar(menuBar);
        this.setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent e){
        if(e.getSource()==loadItem){
            System.out.println("You laoded a file");
        }
        if(e.getSource()==saveItem){
            System.out.println("You saveda file");
        }
        if(e.getSource()==exitItem){
            System.exit(0);
        }
        
    }
}
